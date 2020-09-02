using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCShop.Data;
using PCShop.Klase;

namespace PCShop
{
    public partial class FrmBlagajna : Form
    {
        Korisnik korisnik;
        Kosarica kosarica;
        public FrmBlagajna(Korisnik trenutniKorisnik, Kosarica kosarica)
        {
            InitializeComponent();
            korisnik = trenutniKorisnik;
            this.kosarica = kosarica;
        }

        private void Blagajna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
            {
                string helpFile = System.IO.Path.GetFullPath(@"..\..\Korisnicka_dokumentacija.chm");

                if (System.IO.File.Exists(helpFile))
                {
                    Help.ShowHelp(this, helpFile);
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            try
            {
                VerifikacijaUnosa();
                DateTime datumNarudzbe = DateTime.Now;
                int brojNarudzbe = 0;
                if(ProvjeraKolicineArtikala())
                {
                    brojNarudzbe = UnosNarudzbe(datumNarudzbe);
                    UnosPodatakaOPlacanju(datumNarudzbe, brojNarudzbe);
                    UnosStavakaNarudzbe(brojNarudzbe);
                    MessageBox.Show("Proizvod je uspješno naručen");
                    Close();
                }
                else
                {
                    MessageBox.Show("U skladištu nedostaje proizvoda!");
                }
               
            }
            catch (BlagajnaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            
            
        }

        private void FrmBlagajna_Load(object sender, EventArgs e)
        {
            rbtnPouzece.Checked = true;
            dtpVrijediDo.CustomFormat = "MM/yy";
        }

        private void rbtnPouzece_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnPouzece.Checked == true)
            {
                txtBrojRacuna.Enabled = false;
                txtKontrolniBroj.Enabled = false;
                dtpVrijediDo.Enabled = false;
            }
            else
            {
                txtBrojRacuna.Enabled = true;
                txtKontrolniBroj.Enabled = true;
                dtpVrijediDo.Enabled = true;
            }
        }

        private void cbPostojecaAdresa_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPostojecaAdresa.Checked == true)
            {
                txtAdresa.Text = korisnik.Adresa;
                txtGrad.Text = korisnik.Grad;
                txtPostanskiBroj.Text = korisnik.PostanskiBroj;
            }
            else
            {
                txtAdresa.Text = "";
                txtGrad.Text = "";
                txtPostanskiBroj.Text = "";
            }
        }

        private void VerifikacijaUnosa()
        {
       
            //Verifikacija naziva grada
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtGrad.Text))
            {
                throw new BlagajnaException("Naziv grada mora biti definiran.");
            }
            //Verifikacija adrese stanovanja
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                throw new BlagajnaException("Adresa stanovanja mora biti definirana.");
            }
            //Verifikacija poštanskog broja
            //Ako je polje prazno, baca se iznimka.
            //U slučaju da polje ne sadrži vrijednost tipa "int", baca se iznimka.
            int pomocnaVarijabla;
            if (string.IsNullOrEmpty(txtPostanskiBroj.Text))
            {
                throw new BlagajnaException("Poštanski broj mora biti definiran.");
            }
            else if (!int.TryParse(txtPostanskiBroj.Text, out pomocnaVarijabla) || txtPostanskiBroj.Text.Length < 5)
            {
                throw new BlagajnaException("Poštanski broj mora biti napisan u ispravnom formatu.");
            }

            if(rbtnKartica.Checked == true)
            {
                //Verifikacija broja računa
                //Ako je polje prazno, baca se iznimka.
                if (string.IsNullOrEmpty(txtBrojRacuna.Text))
                {
                    throw new BlagajnaException("Broj računa mora biti definiran.");
                }

                //Verifikacija kontrolnog broja
                //Ako je polje prazno, baca se iznimka.
                //U slučaju da polje ne sadrži vrijednost tipa "int", baca se iznimka.
                if (string.IsNullOrEmpty(txtKontrolniBroj.Text))
                {
                    throw new BlagajnaException("Kontrolni broj mora biti definiran.");
                }
                else if (!int.TryParse(txtKontrolniBroj.Text, out pomocnaVarijabla) || txtKontrolniBroj.Text.Length < 3)
                {
                    throw new BlagajnaException("Kontrolni broj mora biti napisan u ispravnom formatu.");
                }

                //Verifikacija datuma isteka kartice
                //Ako je datum u prošlosti, izbacuje se iznimka
                if (dtpVrijediDo.Value < DateTime.Now)
                {
                    throw new BlagajnaException("Datum kartice je nevažeći.");
                }
            }
        }

        private int UnosNarudzbe(DateTime datumNarudzbe)
        {
            using (var db = new Entities())
            {
                Narudzba novaNarudzba = new Data.Narudzba
                {
                    DatumNarudzbe = datumNarudzbe,
                    GradDostave = txtGrad.Text,
                    AdresaDostave = txtAdresa.Text,
                    PostanskiBroj = txtPostanskiBroj.Text,
                    KorisnikId = korisnik.Korisnik_Id,
                    StanjeNarudzbe = 1
                };
                db.Narudzbas.Add(novaNarudzba);
                db.SaveChanges();

                return novaNarudzba.Narudzba_Id;
            }
        }

        private void UnosPodatakaOPlacanju(DateTime datumNarudzbe, int brojNarudzbe)
        {
            using (var db = new Entities())
            {
                Podaci_o_placanju noviPodaciOPlacanju;
                if (rbtnKartica.Checked == true)
                {
                    noviPodaciOPlacanju = new Podaci_o_placanju
                    {
                        BrojNarudzbe = brojNarudzbe,
                        BrojRacuna = txtBrojRacuna.Text,
                        KontrolniBroj = txtKontrolniBroj.Text,
                        NacinPlacanja = 2,
                        VrijediDo = dtpVrijediDo.Value
                    };
                }
                else
                {
                    noviPodaciOPlacanju = new Podaci_o_placanju(brojNarudzbe, 1);
                }
                   db.Podaci_o_placanju.Add(noviPodaciOPlacanju);
                   db.SaveChanges();
            }
        }

        private bool ProvjeraKolicineArtikala()
        {
            using (var db = new Entities())
            {
                var stavkeKosarice = from stavka in db.Stavka_kosarice
                                     join artikl in db.Artikls
                                     on stavka.Artikl_Id equals artikl.Artikl_Id
                                     where stavka.Kosarica_Id == kosarica.Kosarica_Id
                                     select new { ArtiklId = stavka.Artikl_Id, Cijena = artikl.Cijena, Popust = artikl.Popust, 
                                         KolicinaKosarice = stavka.Kolicina, KolicinaArtikla = artikl.Kolicina };

                foreach (var stavka in stavkeKosarice)
                {
                    int? kolicina = stavka.KolicinaArtikla - stavka.KolicinaKosarice;
                   if (kolicina < 0)
                   {
                        return false;
                   }
                   else
                   {
                        Artikl artikl = new Artikl { Artikl_Id = stavka.ArtiklId };
                        db.Artikls.Attach(artikl);
                        db.Entry(artikl).Property("Kolicina").CurrentValue = kolicina;
                   }
                }
                db.SaveChanges();
                return true;
            }   
        }
        private void UnosStavakaNarudzbe(int brojNarudzbe)
        {
            using (var db = new Entities())
            {
                var stavkeKosarice = from stavka in db.Stavka_kosarice
                                     join artikl in db.Artikls
                                     on stavka.Artikl_Id equals artikl.Artikl_Id
                                     where stavka.Kosarica_Id == kosarica.Kosarica_Id
                                     select new { ArtiklId = stavka.Artikl_Id, Cijena = artikl.Cijena,Popust = artikl.Popust, Kolicina = stavka.Kolicina };
                
                foreach (var stavka in stavkeKosarice)
                {
                    Stavka_narudzbe novaStavkaNarudzbe = new Stavka_narudzbe
                    {
                        Artikl_Id = stavka.ArtiklId,
                        Cijena = stavka.Cijena - stavka.Cijena * stavka.Popust / 100, 
                        Kolicina = stavka.Kolicina,
                        Narudzba_Id = brojNarudzbe
                    };
                    db.Stavka_narudzbe.Add(novaStavkaNarudzbe);
                }
                db.Stavka_kosarice.RemoveRange(db.Stavka_kosarice.Where(stavka => stavka.Kosarica_Id == kosarica.Kosarica_Id));
                db.SaveChanges();
            }
        }
    }
}
