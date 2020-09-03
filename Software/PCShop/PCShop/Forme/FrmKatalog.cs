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
using PCShop.Forme;
using PCShop.Data;
using System.Collections.ObjectModel;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using iText.StyledXmlParser.Jsoup.Nodes;
using Entities = PCShop.Data.Entities;

namespace PCShop
{
    public partial class FrmKatalog : Form
    {
        readonly SqlConnection conn = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=PI20_011_DB; User ID=PI20_011_User; Password=g{+EKZ99");
        SqlCommand naredba;
        SqlDataReader dr;
        Korisnik trenutniKorisnik;
        Kosarica trenutnaKosarica;

        private string upitVrstaArtikla;
        private string sortiranje;
        private string upitArtikl;
        private string upitPosebna;
        private string upitTrazilicaArtikl;
        private string upitTrazilicaPosebna;
        private string trazilica;

        private bool dostupno = true;
        private bool pretraga = false;
        private bool opcijaPopust = true;

        private PictureBox slika;
        private PictureBox slikaPosebnaPonuda;
       
        private Label cijena;
        private Label naziv;
        private Label cijenaPosebnaPonuda;
        private Label nazivPosebnaPonuda;

        readonly DateTime datum = DateTime.Now.AddDays(-31);

        public FrmKatalog()
        {
            InitializeComponent();
        }

        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            rbtnPopust.Checked = true;
            Osvjezi();
            Bitmap img = new Bitmap("../../Slike/UserIcon.png");
            pbKorisnik.Image = img;
        }

        //Metoda za koristi za kreiranje popisa posebnih(Popust/Datum dodavanja) artikla kataloga, isčitivaju se vrijednosti artibuta skupa sa slikom te se dodaju u flowlayout i slažu u red jedan za drugim
        private void PopisPosebnihPonuda(string upit)
        {
            
            flpPosebna.Controls.Clear();
            conn.Open();
            naredba = new SqlCommand(upit, conn);
            naredba.Parameters.AddWithValue("@trazilica", trazilica);
            naredba.Parameters.AddWithValue("@datum", datum);
            dr = naredba.ExecuteReader();
          
            while (dr.Read())
            {
                if(!dr.IsDBNull(0)){  
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                    slikaPosebnaPonuda = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = dr["artikl_id"].ToString(),
                        Cursor = System.Windows.Forms.Cursors.Hand
                    };

                cijenaPosebnaPonuda = new Label();
                double praviIznos = ((double)dr["cijena"] - (double)dr["cijena"] * (double)dr["popust"] / 100);
                cijenaPosebnaPonuda.Text = String.Format("{0:0.00} Kn", praviIznos);
                cijenaPosebnaPonuda.Width = 100;
                cijenaPosebnaPonuda.BackColor = Color.FromArgb(46, 134, 222);
                cijenaPosebnaPonuda.TextAlign = ContentAlignment.MiddleCenter;
                cijenaPosebnaPonuda.BorderStyle = BorderStyle.FixedSingle;

                    nazivPosebnaPonuda = new Label
                    {
                        Text = dr["naziv"].ToString(),
                        BackColor = Color.FromArgb(0, 150, 136),
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

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
        //Metoda za koristi za kreiranje popisa svih artikla kataloga, isčitivaju se vrijednosti artibuta skupa sa slikom te se dodaju u flowlayout i slažu u red jedan za drugim
        private void PopisArtikla(string upitPopisa)
        {

            flpArtikli.Controls.Clear();
            conn.Open();
            naredba = new SqlCommand(upitPopisa, conn);
            naredba.Parameters.AddWithValue("@trazilica", trazilica);
            naredba.Parameters.AddWithValue("@datum", datum);
            dr = naredba.ExecuteReader();

            while (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    long len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                    slika = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = dr["artikl_id"].ToString(),
                        Cursor = System.Windows.Forms.Cursors.Hand
                    };

                    cijena = new Label();
                    double praviIznos = ((double)dr["cijena"] - (double)dr["cijena"] * (double)dr["popust"] / 100);
                    cijena.Text =String.Format("{0:0.00} Kn",praviIznos);
                    cijena.Width = 100;
                    cijena.BackColor = Color.FromArgb(46, 134, 222);
                    cijena.TextAlign = ContentAlignment.MiddleCenter;
                    cijena.BorderStyle = BorderStyle.FixedSingle;


                    naziv = new Label
                    {
                        Text = dr["naziv"].ToString(),
                        BackColor = Color.FromArgb(0, 150, 136),
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

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
        //Metoda se poziva kada se odabere neki od artikala u katalogu te se iz baze povuku informacije o artiklu i prikažu ako je artikl dostupan za prodaju
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

            if (dostupno == true)
            {
                FrmArtikl forma = new FrmArtikl(oznaka, trenutnaKosarica);
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
        //Osvjezuju se svi podaci kako bi se moglo ponovo ispočetka krenut sortirat
        private void Osvjezi()
        {
            CiscenjeOznakaKategorije();
            upitVrstaArtikla = "";
            sortiranje = "";
            upitArtikl = "";
            upitPosebna = "";
            upitTrazilicaArtikl = "";
            upitTrazilicaPosebna = "";
            trazilica = "";
            txbPretraga.Text = "Pretraži...";
            pretraga = false;
            upitArtikl = "SELECT slika, naziv, cijena, artikl_id, popust FROM Artikl";
            upitPosebna = "SELECT slika,cijena,naziv,popust,artikl_id FROM Artikl WHERE popust > 0";
            if (opcijaPopust == false)
            {
                upitPosebna = "SELECT slika,cijena,naziv,popust,artikl_id FROM Artikl WHERE DatumDodavanja >= @datum";
            }
            PopisArtikla(upitArtikl);
            PopisPosebnihPonuda(upitPosebna);
        }

        //Ako postoji korisnik ispisuje se njegovo korisničko ime, inače se ispisuje tekst "Gost".
        public void IspisKorisnickogImena()
        {
            if(trenutniKorisnik!=null)
            {
                lblKorisnikoIme.Text = trenutniKorisnik.KorisnickoIme;
            }
            else
            {
                lblKorisnikoIme.Text = "Gost";
            }
        }
        //Metoda se poziva kako bi se riječi SQL naredbe spojile u smislenu rečenicu upita
        public string SQLKreator(string vrsta, string stupci, string sortiranje)
        {
            string sqlNaredba = "SELECT " + stupci + " FROM Artikl " + vrsta + " " + sortiranje;
            return sqlNaredba;
        }
        //Metoda se poziva kad se katalog, odnosno popis artikala treba sortirati na bilo koji način
        //Preko ispitivanja stanja varijabli kreiraju se dijelovi rečenice za SQL naredbu upita
        public void Sort(string opcija, string vrsta)
        {
            string sortiranjeOpcija = "";
            string sortiranjePosebna;
            string sortiranjePopust = "popust > 0";
            string sortiranjeNovi = "DatumDodavanja >= @datum ";
            string stupci = "slika, naziv, cijena, artikl_id, popust, VrstaArtikla";

            if (opcijaPopust)
            {
                sortiranjePosebna = sortiranjePopust;
            }
            else
            {
                sortiranjePosebna = sortiranjeNovi;
            }

            if (opcija == "Naziv/Uzlazno")
            {
                sortiranjeOpcija = "ORDER BY naziv ASC";
                if (pretraga == false)
                {
                    upitArtikl = SQLKreator(vrsta, stupci, sortiranjeOpcija);

                    if (vrsta == "")
                    {
                        sortiranjeOpcija = "WHERE " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    else
                    {
                        sortiranjeOpcija = "AND " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    upitPosebna = SQLKreator(vrsta, stupci, sortiranjeOpcija);
                }
                else
                {
                    if (vrsta == "")
                    {
                        upitArtikl = upitTrazilicaArtikl + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " " + sortiranjeOpcija;
                    }
                    else
                    {
                        upitArtikl = upitTrazilicaArtikl + " AND " + vrsta + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " AND " + vrsta + " " + sortiranjeOpcija;
                    }
                }
            }
            if (opcija == "Naziv/Silazno")
            {
                sortiranjeOpcija = "ORDER BY naziv DESC";
                if (pretraga == false)
                {
                    upitArtikl = SQLKreator(vrsta, stupci, sortiranjeOpcija);

                    if (vrsta == "")
                    {
                        sortiranjeOpcija = "WHERE " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    else
                    {
                        sortiranjeOpcija = "AND " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    upitPosebna = SQLKreator(vrsta, stupci, sortiranjeOpcija);
                }
                else
                {
                    if (vrsta == "")
                    {
                        upitArtikl = upitTrazilicaArtikl + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " " + sortiranjeOpcija;
                    }
                    else
                    {
                        upitArtikl = upitTrazilicaArtikl + " AND " + vrsta + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " AND " + vrsta + " " + sortiranjeOpcija;
                    }
                }
            }
            if (opcija == "Cijena/Uzlazno")
            {
                sortiranjeOpcija = "ORDER BY cijena ASC";
                if (pretraga == false)
                {
                    upitArtikl = SQLKreator(vrsta, stupci, sortiranjeOpcija);

                    if (vrsta == "")
                    {
                        sortiranjeOpcija = "WHERE " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    else
                    {
                        sortiranjeOpcija = "AND " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    upitPosebna = SQLKreator(vrsta, stupci, sortiranjeOpcija);
                }
                else
                {
                    if (vrsta == "")
                    {
                        upitArtikl = upitTrazilicaArtikl + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " " + sortiranjeOpcija;
                    }
                    else
                    {
                        upitArtikl = upitTrazilicaArtikl + " AND " + vrsta + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " AND " + vrsta + " " + sortiranjeOpcija;
                    }
                }
            }
            if (opcija == "Cijena/Silazno")
            {
                sortiranjeOpcija = "ORDER BY cijena DESC";
                if (pretraga == false)
                {
                    upitArtikl = SQLKreator(vrsta, stupci, sortiranjeOpcija);

                    if (vrsta == "")
                    {
                        sortiranjeOpcija = "WHERE " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    else
                    {
                        sortiranjeOpcija = "AND " + sortiranjePosebna + sortiranjeOpcija;
                    }
                    upitPosebna = SQLKreator(vrsta, stupci, sortiranjeOpcija);
                }
                else
                {
                    if(vrsta == "") { 
                        upitArtikl = upitTrazilicaArtikl + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " " + sortiranjeOpcija;
                    }
                    else
                    {
                        upitArtikl = upitTrazilicaArtikl + " AND " + vrsta + " " + sortiranjeOpcija;
                        upitPosebna = upitTrazilicaPosebna + " AND " + vrsta + " " + sortiranjeOpcija;
                    }
                }
            }
            if (opcija == "Vrsta")
            {
                if (pretraga == false)
                {
                    upitArtikl = SQLKreator(upitVrstaArtikla, stupci, "");
                    sortiranjeOpcija = "AND " + sortiranjePosebna;
                    upitPosebna = SQLKreator(upitVrstaArtikla, stupci, sortiranjeOpcija);
                }
                else
                {
                    Trazilica(sortiranjePosebna, sortiranjeOpcija, sortiranjePopust, sortiranjePosebna);

                    upitArtikl = upitTrazilicaArtikl + " AND " + vrsta;
                    upitPosebna = upitTrazilicaPosebna + " AND " + vrsta;
                }
            }
            if (opcija == "Trazilica")
            {
                Trazilica(sortiranjePosebna, sortiranjeOpcija, sortiranjePopust, sortiranjePosebna);
            }
            PopisArtikla(upitArtikl);
            PopisPosebnihPonuda(upitPosebna);
        }
        //Trazilica se koristi kod traženja artikla prema nazivu opisu ili proizvođaču, te kod sortiranja vrste artikla, tako da se ispisuju i kasnije sortiraju samo artikli koji su rezultati pretrage 
        private void Trazilica(string sortPosebna, string sortOpcija, string sortPopust, string sortNovi)
        {
            if (sortOpcija is null)
            {
                throw new ArgumentNullException(nameof(sortOpcija));
            }

            if (sortPopust is null)
            {
                throw new ArgumentNullException(nameof(sortPopust));
            }

            if (sortNovi is null)
            {
                throw new ArgumentNullException(nameof(sortNovi));
            }

            string sortiranjePosebna = sortPosebna;
            string stupci = "slika,opis,naziv,proizvodac,artikl_id,cijena,datumdodavanja,popust,VrstaArtikla";
            string sortiranjeOpcija = "WHERE(naziv LIKE '%' + @trazilica + '%' or cijena LIKE '%' + @trazilica + '%' or proizvodac LIKE '%' + @trazilica + '%' or VrstaArtikla LIKE '%' + @trazilica + '%') ";
            trazilica = txbPretraga.Text;
            upitTrazilicaArtikl = SQLKreator("", stupci, sortiranjeOpcija);
            upitArtikl = upitTrazilicaArtikl;
            sortiranjeOpcija = sortiranjeOpcija + "AND " + sortiranjePosebna;
            upitTrazilicaPosebna = SQLKreator("", stupci, sortiranjeOpcija);
            upitArtikl = upitTrazilicaArtikl;
            upitPosebna = upitTrazilicaPosebna;
            pretraga = true;

        }

        //Prvo se provjerava stanje korisnika. Ako funkcija bude uspješna otvara se forma košarice, a prosljeđuje se trenutni korisnik i košarica. 
        //U suprotnom se ispisuje poruka pogreške.
        private void BtnKosarica_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeraKorisnika();
                FrmKosarica frmKosarica = new FrmKosarica(trenutnaKosarica, trenutniKorisnik);
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

        //Pomocu forme prijave se provjerava je li se korisnik prijavio uspješno. 
        //Ako je prijava uspješna, iz forme prijave se preuzima javni atribut korisnika te se sprema u varijablu "trenutniKorisnik"
        //Nakon toga se kreira kontekst i pomoću njega se pronalazi odgovarajuća košarica na način da se iterira po kolekciji košarica i pronalazi prava košarica.
        //Uspješnom se prijavom u donji lijevi kut ispisuje korisničko ime i prikazuju se gumbi za košaricu i odjavu, a skrivaju gumbi za prijavu i registraciju.
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
                    }
                    IspisKorisnickogImena();
                    btnPrijava.Visible = false;
                    btnOdjava.Visible = true;
                    btnRegistracija.Visible = false;
                    btnKosarica.Visible = true;
                    btnPregledajNarudzbe.Visible = true;
                    if (trenutniKorisnik.TipKorisnika == 1)
                    {
                        btnUpravljajNarudzbama.Visible = true;
                        btnArtikli.Visible = true;
                    }
                }
                
            }
            
            

        }
        //Metoda se poziva kod klika na gumb Kontakt i otvara formu za kontakt firme
        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            FrmKontakt forma = new FrmKontakt();
            forma.ShowDialog();
        }
        private void BtnTrazi_Click(object sender, EventArgs e)
        {
            sortiranje = "Trazilica";
            Sort(sortiranje, upitVrstaArtikla);
            PopisArtikla(upitArtikl);
            PopisPosebnihPonuda(upitPosebna);
        }
        private void BtnOsvjeziPopis_Click(object sender, EventArgs e)
        {

            Osvjezi();

        }
        //Metoda se poziva kod klika na gumb uzlaznog sortiranja prema cijeni
        private void BtnSortCijenaUzlazno_Click(object sender, EventArgs e)
        {
            sortiranje = "Cijena/Uzlazno";
            Sort(sortiranje, upitVrstaArtikla);
        }
        //Metoda se poziva kod klika na gumb silaznog sortiranja prema cijeni
        private void BtnSortCijenaSilazno_Click(object sender, EventArgs e)
        {

            sortiranje = "Cijena/Silazno";
            Sort(sortiranje, upitVrstaArtikla);

        }
        //Metoda se poziva kod klika na gumb uzlaznog sortiranja prema nazivu
        private void BtnSortNazivUzlazno_Click(object sender, EventArgs e)
        {

            sortiranje = "Naziv/Uzlazno";
            Sort(sortiranje, upitVrstaArtikla);

        }
        //Metoda se poziva kod klika na gumb silaznog sortiranja prema nazivu
        private void BtnSortNazivSilazno_Click(object sender, EventArgs e)
        {

            sortiranje = "Naziv/Silazno";
            Sort(sortiranje, upitVrstaArtikla);

        }
        //Metoda se poziva kod klika na labelu Grafičke kartice
        //ovisno o bool vrijednosti pretrage odabire se dio za rečenicu upita te se poziva sortiranje
        private void LblGrafickeKartice_Click(object sender, EventArgs e)
        {
            CiscenjeOznakaKategorije();
            lblGrafickeKartice.BorderStyle = BorderStyle.Fixed3D;
            sortiranje = "Vrsta";
            if (pretraga)
            {
                upitVrstaArtikla = "VrstaArtikla = 1";
            }
            else
            {
                upitVrstaArtikla = "WHERE VrstaArtikla = 1";
            }
            Sort(sortiranje, upitVrstaArtikla);
        }
        //Metoda se poziva kod klika na labelu Procesori
        //ovisno o bool vrijednosti pretrage odabire se dio za rečenicu upita te se poziva sortiranje
        private void LblProcesori_Click(object sender, EventArgs e)
        {
            CiscenjeOznakaKategorije();
            lblProcesori.BorderStyle = BorderStyle.Fixed3D;
            sortiranje = "Vrsta";
            if (pretraga)
            {
                upitVrstaArtikla = "VrstaArtikla = 2";
            }
            else
            {
                upitVrstaArtikla = "WHERE VrstaArtikla = 2";
            }
            Sort(sortiranje, upitVrstaArtikla);
        }
        //Metoda se poziva kod klika na labelu Matične ploče
        //ovisno o bool vrijednosti pretrage odabire se dio za rečenicu upita te se poziva sortiranje
        private void LblMaticnePloce_Click(object sender, EventArgs e)
        {
            CiscenjeOznakaKategorije();
            lblMaticnePloce.BorderStyle = BorderStyle.Fixed3D;
            sortiranje = "Vrsta";
            if (pretraga)
            {
                upitVrstaArtikla = "VrstaArtikla = 3";
            }
            else
            {
                upitVrstaArtikla = "WHERE VrstaArtikla = 3";
            }
            Sort(sortiranje, upitVrstaArtikla);
        }
        //Metoda se poziva kod klika na labelu Radna memorija
        //ovisno o bool vrijednosti pretrage odabire se dio za rečenicu upita te se poziva sortiranje
        private void LblRadnaMemorija_Click(object sender, EventArgs e)
        {
            CiscenjeOznakaKategorije();
            lblRadnaMemorija.BorderStyle = BorderStyle.Fixed3D;
            sortiranje = "Vrsta";
            if (pretraga)
            {
                upitVrstaArtikla = "VrstaArtikla = 4";
            }
            else
            {
                upitVrstaArtikla = "WHERE VrstaArtikla = 4";
            }
            Sort(sortiranje, upitVrstaArtikla);
        }
        //Metoda se poziva kod klika na labelu Tvrdi diskovi
        //ovisno o bool vrijednosti pretrage odabire se dio za rečenicu upita te se poziva sortiranje
        private void LblTvrdiDiskovi_Click(object sender, EventArgs e)
        {
            CiscenjeOznakaKategorije();
            lblTvrdiDiskovi.BorderStyle = BorderStyle.Fixed3D;
            sortiranje = "Vrsta";
            if (pretraga)
            {
                upitVrstaArtikla = "VrstaArtikla = 5";
            }
            else
            {
                upitVrstaArtikla = "WHERE VrstaArtikla = 5";
            }
            Sort(sortiranje, upitVrstaArtikla);
        }
        //Metoda se poziva kod klika na labelu Prebuild PC
        //ovisno o bool vrijednosti pretrage odabire se dio za rečenicu upita te se poziva sortiranje
        private void LblPC_Click(object sender, EventArgs e)
        {
            CiscenjeOznakaKategorije();
            lblPC.BorderStyle = BorderStyle.Fixed3D;
            sortiranje = "Vrsta";
            if (pretraga)
            {
                upitVrstaArtikla = "VrstaArtikla = 7";
            }
            else
            {
                upitVrstaArtikla = "WHERE VrstaArtikla = 7";
            }
            Sort(sortiranje, upitVrstaArtikla);
        }
        //Metoda se poziva prilikom pritiska gumba F1
        //Otvara se chm datoteka s korisničkom dokumentacijom za pomoć
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
        private void BtnArtikli_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeArtiklima forma = new FrmUpravljanjeArtiklima();
            forma.ShowDialog();
            Osvjezi();
        }

        private void LblKorisnikoIme_Click(object sender, EventArgs e)
        {
            if (trenutniKorisnik != null)
            {
                FrmKorisnik forma = new FrmKorisnik(trenutniKorisnik);
                forma.ShowDialog();
            }
        }
        
        //Ako trenutni korisnik nije definiran, baca se nova iznimka
        private void ProvjeraKorisnika()
        {
           if(trenutniKorisnik == null)
            {
                throw new KorisnikException("Za pristup košarici korisnik treba biti prijavljen!");
            }
        }

        //Ako trenutni korisnik postoji, vrijednosti varijabli "trenutniKorisnik" i "trenutnaKosarica" postavljaju se na null, a gumbi za 
        //odjavu i košaricu se sakrivaju, dok gumbi za registraciju i prijavu postaju vidljivi.
        //Ispisuje se poruka o odjavi i poziva se funkcija "IspisKorisnickogImena".
        private void BtnOdjava_Click(object sender, EventArgs e)
        {
            if(trenutniKorisnik != null)
            {
                if (trenutniKorisnik.TipKorisnika == 1)
                {
                    btnUpravljajNarudzbama.Visible = false;
                    btnArtikli.Visible = false;
                }
                trenutniKorisnik = null;
                trenutnaKosarica = null;
                btnOdjava.Visible = false;
                btnPrijava.Visible = true;
                btnRegistracija.Visible = true;
                btnKosarica.Visible = false;
                btnPregledajNarudzbe.Visible = false;
                MessageBox.Show("Odjavljeni ste.");
                IspisKorisnickogImena();
            }
           
        }
        //Metoda se poziva kod promjene odabira posebnih artikala
        //Ako se već sortira po nećemu, poziva se funkcija sort za daljnje sortiranje, u suprotnom se samo osvježi
        private void RbtnNoviProizodi_Click(object sender, EventArgs e)
        {
            rbtnPopust.Checked = false;
            opcijaPopust = false;
            if (sortiranje != "")
            {
                Sort(sortiranje, upitVrstaArtikla);
            }
            else
            {
                Osvjezi();

            }
        }
        //Metoda se poziva kod promjene odabira posebnih artikala
        //Ako se već sortira po nećemu, poziva se funkcija sort za daljnje sortiranje, u suprotnom se samo osvježi
        private void RbtnPopust_Click(object sender, EventArgs e)
        {
            rbtnNoviProizodi.Checked = false;
            opcijaPopust = true;
            if (sortiranje != "")
            {
                Sort(sortiranje, upitVrstaArtikla);
            }
            else
            {
                Osvjezi();

            }
        }

        private void TxbPretraga_Click(object sender, EventArgs e)
        {
            txbPretraga.Text = "";
        }

        //Metoda se poziva kako bi se ocistile istaknute granice labela
        private void CiscenjeOznakaKategorije()
        {
            lblPC.BorderStyle = BorderStyle.None;
            lblProcesori.BorderStyle = BorderStyle.None;
            lblMaticnePloce.BorderStyle = BorderStyle.None;
            lblRadnaMemorija.BorderStyle = BorderStyle.None;
            lblTvrdiDiskovi.BorderStyle = BorderStyle.None;
            lblGrafickeKartice.BorderStyle = BorderStyle.None;
        }

        private void BtnPregledajNarudzbe_Click(object sender, EventArgs e)
        {
            FrmPregledNarudzbi frmPregledNarudzbi = new FrmPregledNarudzbi(trenutniKorisnik);
            frmPregledNarudzbi.ShowDialog();
        }

        private void BtnUpravljajNarudzbama_Click(object sender, EventArgs e)
        {
            FrmUpravljajNarudzbama frmUpravljajNarudzbama = new FrmUpravljajNarudzbama();
            frmUpravljajNarudzbama.ShowDialog();
        }
    }
    }