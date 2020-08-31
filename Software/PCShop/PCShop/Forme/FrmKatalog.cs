using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using PCShop.Klase;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using PCShop.Forme;
using PCShop.Data;
using System.Collections.ObjectModel;

namespace PCShop
{
    public partial class FrmKatalog : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=PI20_011_DB; User ID=PI20_011_User; Password=g{+EKZ99");
        SqlCommand naredba;
        SqlDataReader dr;
        Korisnik trenutniKorisnik;
        Kosarica trenutnaKosarica;

        private bool dostupno = true;
        private string upitVrstaArtikla = "";
       // private string opciUpit = "SELECT slika, naziv, cijena, artikl_id FROM Artikl";
        private string upitArtikl = "";
        private string upitPosebna = "";

        private PictureBox slika;
        private PictureBox slikaPosebnaPonuda;
        private Label cijena;
        private Label naziv;
        private Label cijenaPosebnaPonuda;
        private Label nazivPosebnaPonuda;

        public FrmKatalog()
        {
            InitializeComponent();
        }
        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            rbtnPopust.Checked = true;

            Osvjezi();

            //UcitajSnizeneProizvode();
        }
        private void PopisPosebnihPonuda(string upit)
        {
            
            flpPosebna.Controls.Clear();
            conn.Open();
            naredba = new SqlCommand(upit, conn);
            dr = naredba.ExecuteReader();
            while (dr.Read())
            {
                if(!dr.IsDBNull(0)){  
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                slikaPosebnaPonuda = new PictureBox();
                slikaPosebnaPonuda.Width = 150;
                slikaPosebnaPonuda.Height = 150;
                slikaPosebnaPonuda.BackgroundImageLayout = ImageLayout.Stretch;
                slikaPosebnaPonuda.Tag = dr["artikl_id"].ToString();
                slikaPosebnaPonuda.Cursor = System.Windows.Forms.Cursors.Hand;

                cijenaPosebnaPonuda = new Label();
                double praviIznos = ((double)dr["cijena"] - (double)dr["cijena"] * (double)dr["popust"] / 100);
                cijenaPosebnaPonuda.Text = String.Format("{0:0.00} Kn", praviIznos);
                cijenaPosebnaPonuda.Width = 100;
                cijenaPosebnaPonuda.BackColor = Color.FromArgb(46, 134, 222);
                cijenaPosebnaPonuda.TextAlign = ContentAlignment.MiddleCenter;
                cijenaPosebnaPonuda.BorderStyle = BorderStyle.FixedSingle;


                nazivPosebnaPonuda = new Label();
                nazivPosebnaPonuda.Text = dr["naziv"].ToString();
                nazivPosebnaPonuda.BackColor = Color.FromArgb(0, 150, 136);
                nazivPosebnaPonuda.Dock = DockStyle.Bottom;
                nazivPosebnaPonuda.TextAlign = ContentAlignment.MiddleCenter;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);

                slikaPosebnaPonuda.BackgroundImage = bitmap;
                slikaPosebnaPonuda.Controls.Add(cijenaPosebnaPonuda);
                slikaPosebnaPonuda.Controls.Add(nazivPosebnaPonuda);

                  
                flpPosebna.Controls.Add(slikaPosebnaPonuda);
              
                slikaPosebnaPonuda.Click += new EventHandler(OnClick);
                }
                else
                {
                    MessageBox.Show("Fali slika! ID: " + dr["artikl_id"].ToString());
                }
                
            }
            dr.Close();
            conn.Close();
        }

        private void PopisArtikla(string upitPopisa)
        {

            flpArtikli.Controls.Clear();
            conn.Open();
            naredba = new SqlCommand(upitPopisa, conn);
            dr = naredba.ExecuteReader();
            while (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    long len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                    slika = new PictureBox();
                    slika.Width = 150;
                    slika.Height = 150;
                    slika.BackgroundImageLayout = ImageLayout.Stretch;
                    slika.Tag = dr["artikl_id"].ToString();
                    slika.Cursor = System.Windows.Forms.Cursors.Hand;

                    cijena = new Label();
                    double praviIznos = ((double)dr["cijena"] - (double)dr["cijena"] * (double)dr["popust"] / 100);
                    cijena.Text =String.Format("{0:0.00} Kn",praviIznos);
                    cijena.Width = 100;
                    cijena.BackColor = Color.FromArgb(46, 134, 222);
                    cijena.TextAlign = ContentAlignment.MiddleCenter;
                    cijena.BorderStyle = BorderStyle.FixedSingle;


                    naziv = new Label();
                    naziv.Text = dr["naziv"].ToString();
                    naziv.BackColor = Color.FromArgb(0, 150, 136);
                    naziv.Dock = DockStyle.Bottom;
                    naziv.TextAlign = ContentAlignment.MiddleCenter;

                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    slika.BackgroundImage = bitmap;


                    slika.Controls.Add(cijena);
                    slika.Controls.Add(naziv);

                    flpArtikli.Controls.Add(slika);

                    slika.Click += new EventHandler(OnClick);
                }
                else
                {
                    MessageBox.Show("Fali slika! ID: " + dr["artikl_id"].ToString());
                }

            }
            dr.Close();
            conn.Close();
        }
        public void OnClick(object sender, EventArgs e)
        {
            String oznaka = ((PictureBox)sender).Tag.ToString();
            conn.Open();
            naredba = new SqlCommand("SELECT artikl_id, kolicina FROM Artikl WHERE artikl_id = @oznaka", conn);
            naredba.Parameters.AddWithValue("@oznaka", oznaka);
            dr = naredba.ExecuteReader();
            while (dr.Read())
            {
                if (int.Parse(dr["kolicina"].ToString()) <= 0)
                    dostupno = false;
            }

            if (dostupno == true) { 
                FrmArtikl forma = new FrmArtikl(oznaka,trenutnaKosarica);
                forma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Artikl trenutno nije dostupan na zalihama.");
                dostupno = true;
            }
            dr.Close();
            conn.Close();
        }
    
        private void Osvjezi()
        {
            upitArtikl = "SELECT slika, naziv, cijena, artikl_id,popust FROM Artikl";
            upitPosebna = "SELECT slika,cijena,naziv,popust,artikl_id FROM Artikl WHERE popust > 0";
            PopisArtikla(upitArtikl);
            PopisPosebnihPonuda(upitPosebna);
            IspisKorisnickogImena();
        }

        public void IspisKorisnickogImena()
        {
            if(trenutniKorisnik!=null)
            {
                lblKorisnikoIme.Text = trenutniKorisnik.KorisnickoIme;
            }
        }
        public void Sortiranje(string opcija,string vrsta)
        {
            
            if (opcija == "Naziv/Uzlazno")
            {
                upitArtikl = "SELECT slika, naziv, cijena, artikl_id, VrstaArtikla FROM Artikl " + vrsta + " ORDER BY naziv ASC";
                upitPosebna = "SELECT slika, naziv, cijena, artikl_id, popust, VrstaArtikla FROM Artikl " + vrsta + "AND popust > 0 ORDER BY naziv ASC";
            }

            if (opcija == "Naziv/Silazno")
            {
                upitArtikl = "SELECT slika, naziv, cijena, artikl_id, VrstaArtikla FROM Artikl " + vrsta + " ORDER BY naziv DESC";
                upitPosebna = "SELECT slika, naziv, cijena, artikl_id, popust, VrstaArtikla FROM Artikl " + vrsta + " AND (popust > 0) ORDER BY naziv ASC";
            }

            if (opcija == "Cijena/Uzlazno")
            {
                upitArtikl = "SELECT slika, naziv, cijena, artikl_id, VrstaArtikla FROM Artikl " + vrsta + " ORDER BY cijena ASC";
                upitPosebna = "SELECT slika, naziv, cijena, artikl_id, popust, VrstaArtikla FROM Artikl " + vrsta + " AND popust > 0 ORDER BY naziv ASC";
            }

            if (opcija == "Cijena/Silazno")
            {
                
                    upitArtikl = "SELECT slika, naziv, cijena, artikl_id, VrstaArtikla FROM Artikl " + vrsta + " ORDER BY cijena DESC";
                if(vrsta == "")
                {
                upitPosebna = "SELECT slika, naziv, cijena, artikl_id, popust, VrstaArtikla FROM Artikl WHERE popust > 0 ORDER BY naziv ASC";
                }
                else
                {
                upitPosebna = "SELECT slika, naziv, cijena, artikl_id, popust, VrstaArtikla FROM Artikl " + vrsta + " AND popust > 0 ORDER BY naziv ASC";
                }
            }
               
            if(opcija == "Vrsta")
            {
                upitArtikl = "SELECT slika, naziv, cijena, artikl_id, VrstaArtikla FROM Artikl " + vrsta;
                if(vrsta == "")

                upitPosebna = "SELECT slika, naziv, cijena, artikl_id, popust, VrstaArtikla FROM Artikl " + vrsta + "popust > 0 ORDER BY naziv ASC";
                upitPosebna = "SELECT slika, naziv, cijena, artikl_id, popust, VrstaArtikla FROM Artikl " + vrsta + " AND popust > 0 ORDER BY naziv ASC";
            }
            PopisArtikla(upitArtikl);
            PopisPosebnihPonuda(upitPosebna);

        }
        private void BtnKosarica_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeraKorisnika();
                FrmKosarica frmKosarica = new FrmKosarica(trenutnaKosarica);
                frmKosarica.ShowDialog();
            }
            catch (KorisnikException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
           
            
        }
        private void BtnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija frmRegistracija = new FrmRegistracija();
            frmRegistracija.ShowDialog();

        }
        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            using (var frmPrijava = new FrmPrijava())
            {
                var result = frmPrijava.ShowDialog();
                if(result == DialogResult.OK)
                {
                    trenutniKorisnik = frmPrijava.Korisnik;
                    using (var db = new Entities())
                    {
                        db.Korisniks.Attach(trenutniKorisnik);
                        ICollection<Kosarica> popisKosarica = trenutniKorisnik.Kosaricas;
                        foreach (var kosarica in popisKosarica)
                        {
                            if (kosarica.Korisnik == trenutniKorisnik.Korisnik_Id)
                            {
                                trenutnaKosarica = new Kosarica();
                                trenutnaKosarica = kosarica;
                            }
                        }
                        IspisKorisnickogImena();
                    }
                    
                }
                
            }
            
            

        }
        private void BtnOtvoriArtikl_Click(object sender, EventArgs e)
        {
            /*
            //Artikl odabraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
           // FrmArtikli frmArtikli = new FrmArtikli(odabraniArtikl);
           // frmArtikli.ShowDialog();
            */
        }
        private void BtnKontakt_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ovo je kontakt firme");
            
        }
        private void BtnTrazi_Click(object sender, EventArgs e)
        {
            /*
            pretraga = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
            
                if (artikl.Naziv == txbPretraga.Text && pretraga.Contains(artikl) == false)
                {
                    pretraga.Add(artikl);
                }
            }
            trenutniPopis = pretraga;
            Osvjezi(pretraga);
            */
        }
        private void BtnOsvjeziPopis_Click(object sender, EventArgs e)
        {
           
            Osvjezi();
            
        }
        private void BtnSortCijenaUzlazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Cijena/Uzlazno";
            Sortiranje(sortiranje, upitVrstaArtikla);
        }
        private void BtnSortCijenaSilazno_Click(object sender, EventArgs e)
        {
            
            string sortiranje = "Cijena/Silazno";
            Sortiranje(sortiranje, upitVrstaArtikla);
            
        }
        private void BtnSortNazivUzlazno_Click(object sender, EventArgs e)
        {
            
            string sortiranje = "Naziv/Uzlazno";
            Sortiranje(sortiranje, upitVrstaArtikla);
            
        }
        private void BtnSortNazivSilazno_Click(object sender, EventArgs e)
        {
            
            string sortiranje = "Naziv/Silazno";
            Sortiranje(sortiranje, upitVrstaArtikla);
            
        }
        private void LblGrafickeKartice_Click(object sender, EventArgs e)
        {
            string sortiranje = "Vrsta";
            upitVrstaArtikla = "WHERE VrstaArtikla = 1";
            Sortiranje(sortiranje,upitVrstaArtikla);
        }
        private void LblProcesori_Click(object sender, EventArgs e)
        {
            string sortiranje = "Vrsta";
            upitVrstaArtikla = "WHERE VrstaArtikla = 2";
            Sortiranje(sortiranje, upitVrstaArtikla);
        }
        private void LblMaticnePloce_Click(object sender, EventArgs e)
        {
            string sortiranje = "Vrsta";
            upitVrstaArtikla = "WHERE VrstaArtikla = 3";
            Sortiranje(sortiranje, upitVrstaArtikla);
        }
        private void LblRadnaMemorija_Click(object sender, EventArgs e)
        {
            string sortiranje = "Vrsta";
            upitVrstaArtikla = "WHERE VrstaArtikla = 4";
            Sortiranje(sortiranje, upitVrstaArtikla);
        }
        private void LblTvrdiDiskovi_Click(object sender, EventArgs e)
        {
            string sortiranje = "Vrsta";
            upitVrstaArtikla = "WHERE VrstaArtikla = 5";
            Sortiranje(sortiranje, upitVrstaArtikla);
        }

        private void LblPC_Click(object sender, EventArgs e)
        {
            /*
            TrazenaKategorija(VrstaArtikla.prebuilt);
            */
        }

        private void FrmKatalog_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if(e.KeyValue == 112)
            {
                string helpFile = System.IO.Path.GetFullPath(@"..\..\Korisnicka_dokumentacija.chm");

                if (System.IO.File.Exists(helpFile))
                {
                    Help.ShowHelp(this, helpFile);
                }
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtnPopust_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (rbtnPopust.Checked)
            {
                UcitajSnizeneProizvode();
            }
            else
            {
                UcitajNoveProizvode();
            }
            */
        }

        private void UcitajSnizeneProizvode()
        {
            /*
            snizeniProizvodi = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.Popust > 0 && snizeniProizvodi.Contains(artikl) == false)
                {
                    snizeniProizvodi.Add(artikl);
                }
            }
            dgvPosebna.DataSource = null;
            dgvPosebna.DataSource = snizeniProizvodi;
            */
        }
        private void UcitajNoveProizvode()
        {
            /*
            snizeniProizvodi = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.DatumDodavanja < artikl.DatumDodavanja.AddDays(21) && snizeniProizvodi.Contains(artikl) == false)
                {
                    snizeniProizvodi.Add(artikl);
                }
            }
            dgvPosebna.DataSource = null;
            dgvPosebna.DataSource = snizeniProizvodi;
            */
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeArtiklima forma = new FrmUpravljanjeArtiklima();
            forma.ShowDialog();
            Osvjezi();
        }

        private void lblKorisnikoIme_Click(object sender, EventArgs e)
        {

        }
        
        private void ProvjeraKorisnika()
        {
           if(trenutniKorisnik == null)
            {
                throw new KorisnikException("Za pristup košarici korisnik treba biti prijavljen!");
            }
        }
    }

    }