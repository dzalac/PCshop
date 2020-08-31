using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using PCShop.Forme;
using PCShop.Klase;
using PCShop.Data;

namespace PCShop
{
    public partial class FrmArtikl : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=PI20_011_DB; User ID=PI20_011_User; Password=g{+EKZ99");
        SqlCommand naredba;
        SqlDataReader dr;
        Kosarica aktivnaKosarica;

        private PictureBox slika;
        private string oznaka;
        private Korisnik trenutniKorisnik;

        public FrmArtikl(string tag, Kosarica trenutnaKosarica)
        {
            InitializeComponent();
            oznaka = tag;
            aktivnaKosarica = trenutnaKosarica;
        }

        public FrmArtikl(string oznaka, Korisnik trenutniKorisnik)
        {
            this.oznaka = oznaka;
            this.trenutniKorisnik = trenutniKorisnik;
        }

        private void FrmArtikl_Load(object sender, EventArgs e)
        {
            conn.Open();
            naredba = new SqlCommand("SELECT slika,artikl_id,cijena,naziv,opis,popust FROM Artikl WHERE artikl_id = " + oznaka, conn);
            dr = naredba.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pbSlika.BackgroundImage = bitmap;
                pbSlika.BackgroundImageLayout = ImageLayout.Stretch;

                rtbxOpis.Text = dr["opis"].ToString();
                double praviIznos = ((double)dr["cijena"] - (double)dr["cijena"] * (double)dr["popust"] / 100);
                lblCijena.Text = String.Format("{0:0.00} Kn", praviIznos);
                lblNaziv.Text = dr["naziv"].ToString();
                if((double)dr["popust"]>0)
                {
                    lblStaraCijena.Visible = true;
                    lblStaraCijenaIznos.Visible = true;
                    lblStaraCijenaIznos.Text = String.Format("{0:0.00} Kn", (double)dr["cijena"]);
                }
            }
            dr.Close();
            conn.Close();
        }

        //Provjerava se unos u poljima, ako postoji greška ispisuje se poruka na ekranu, inače se kreira kontekst i dohvaća artikl pomoću proslijeđenog Id-a
        //Provjerava se postoji li već stavka košarice određenog artikla u košarici.
        //Ako postoji na postojeću se stavku dodaje količina zadana u tekstualnom polju,
        //inače se kreira nova stavka košarice u koju se upisuje količina i Id aritkla.
        //Stavka se dodaje u bazu i spremaju se promjene.
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacijaUnosa();
                using(var db = new Entities())
                {
                    int idArtikla = int.Parse(oznaka);
                    var artikl = db.Artikls.First(a => a.Artikl_Id == idArtikla);
                    Stavka_kosarice postojecaStavka = db.Stavka_kosarice.FirstOrDefault(stavka => stavka.Artikl_Id == idArtikla 
                    && stavka.Kosarica_Id == aktivnaKosarica.Kosarica_Id);
                    if(postojecaStavka != null)
                    {
                        db.Stavka_kosarice.Attach(postojecaStavka);
                        postojecaStavka.Kolicina += int.Parse(txtKolicina.Text);
                    }
                    else
                    {
                        Stavka_kosarice stavkaKosarice = new Stavka_kosarice
                        {
                            Kosarica_Id = aktivnaKosarica.Kosarica_Id,
                            Artikl_Id = artikl.Artikl_Id,
                            Kolicina = int.Parse(txtKolicina.Text)
                        };
                        db.Stavka_kosarice.Add(stavkaKosarice);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Artikl uspješno dodan!");
                }
                Close();
            }
            catch (PCShopExcepiton ex) when (ex is KorisnikException || ex is ArtiklException)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void ValidacijaUnosa()
        {
            //Provjera je li korisnik prijavljen
            if (aktivnaKosarica == null)
            {
                throw new KorisnikException("Za dodavanje artikala u košaricu korisnik mora biti prijavljen.");
            }
            //Provjera količine
            int pomocnaVarijabla;
            if (!int.TryParse(txtKolicina.Text, out pomocnaVarijabla))
            {
                throw new ArtiklException("Količina mora biti numeričke vrijednosti."); 
            }
            else if (int.Parse(txtKolicina.Text) < 0)
            {
                throw new ArtiklException("Količina mora biti pozitivna.");
            }            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
