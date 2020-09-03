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
using PCShop.Forme;

namespace PCShop
{
    public partial class FrmBlagajna : Form
    {
        readonly Korisnik korisnik;
        readonly Kosarica kosarica;
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

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNaruci_Click(object sender, EventArgs e)
        {
            try
            {
                VerifikacijaUnosa();
                DateTime datumNarudzbe = DateTime.Now;
                int brojNarudzbe = 0;
                if(ProvjeraKolicineArtikala())
                {
                    brojNarudzbe = UnosNarudzbe(datumNarudzbe);
                    UnosPodatakaOPlacanju(brojNarudzbe);
                    UnosStavakaNarudzbe(brojNarudzbe);
                    MessageBox.Show("Proizvod je uspješno naručen");
                    OtvoriIzvjestaj(brojNarudzbe);
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

        //Kada se promijeni stanje radio gumba rbtnPouzece, provjerava se je li označen ili nije.
        //Ako je označen polja u koja se unose informacije o kartičnom plaćanju se isključuju, inače se uključuju.
        private void RbtnPouzece_CheckedChanged(object sender, EventArgs e)
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

        //Kada se promijeni stanje CheckBox-a "cbPostojecaAdresa", provjerava se njegovo stanje.
        //Ako je CheckBox označen, polja za informacije o adresi dostave se popunjavaju korisnikovim informacijama navedenim pri registraciji.
        //U slučaju da CheckBox nije označen, polja ostaju prazna.
        private void CbPostojecaAdresa_CheckedChanged(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtPostanskiBroj.Text))
            {
                throw new BlagajnaException("Poštanski broj mora biti definiran.");
            }
            else if (!int.TryParse(txtPostanskiBroj.Text, out _) || txtPostanskiBroj.Text.Length < 5)
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
                else if (!int.TryParse(txtKontrolniBroj.Text, out _) || txtKontrolniBroj.Text.Length < 3)
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
        //U novome se kontekstu kreira novi objekt tipa Narudzba. 
        //Novoj se narudžbi atributi postavljaju na zadane vrijednosti te se narudžba dodaje u bazu i promijene se spremaju.
        //Zbog toga što ostale funkcije ovise o broju narudžbe, ova funkcija vraća Id novokreirane narudžbe.
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

        //Ulazni parametar ove funkcije je brojNarudzbe i tipa je int.
        //Kreira se novi kontekst i nakon toga se deklarira se objekt tipa "Podaci_o_placanju" naziva "noviPodaciOPlacanju" u kojemu će biti spremljeni podaci o plaćanju.
        //Ako se narudžba plaća kartičnim plaćanjem, popunjavaju se svi potrebni atributi (BrojNarudzbe, BrojRacuna, KontrolniBroj, NacinPlacanja i VrijediDo).
        //Međutim, ako se radi o plaćanjem pouzećem, tj. gotovinom pomoću posebnog konstruktora se popnjavaju samo atributi BrojNarudzbe i NacinPlacanja.
        //Novi se objekt dodaje u bazu i spremaju se promijene.
        private void UnosPodatakaOPlacanju(int brojNarudzbe)
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

        //Kako se ne bi dogodilo da kupac naruči više proizoda nego što je dostupno u skladištu, potrebno je napraviti provjeru količine artikala na skladištu.
        //Pomoću LINQ-a se dohvaćaju potrebni podaci iz tablica "Stavka_kosarice" i "Artikls" gdje stavke odgovaraju korisnikovoj košarici.
        //Za svaku se stavku računa razlika količine artikla u skladištu i naručenog broja.
        //Ako je razlika negativna vraća se bool vrijednost "false"; u suprotnom se dohvaća artikl, smanjuje mu se količina te se spremaju promjene i na kraju
        //se vraća bool vrijednost "true".
       
        private bool ProvjeraKolicineArtikala()
        {
            using (var db = new Entities())
            {
                var stavkeKosarice = from stavka in db.Stavka_kosarice
                                     join artikl in db.Artikls
                                     on stavka.Artikl_Id equals artikl.Artikl_Id
                                     where stavka.Kosarica_Id == kosarica.Kosarica_Id
                                     select new { ArtiklId = stavka.Artikl_Id,
                                         artikl.Cijena,
                                         artikl.Popust,
                                         KolicinaKosarice = stavka.Kolicina,
                                         KolicinaArtikla = artikl.Kolicina
                                     };

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
        //Pomoću LINQ-a se dohvaćaju potrebni podaci iz tablica "Stavka_kosarice" i "Artikls" gdje stavke odgovaraju korisnikovoj košarici.
        //Za svaku zapis iz dohvaćenog popisa kreira se novi objekt tipa "Stavka_narudzbe" i popunjava se dohvaćenim podacima.
        //Svaki se novi objekt dodaje u bazu podataka, a nakon toga se prazni košarica.
        //Sve promijene se spremaju.
        private void UnosStavakaNarudzbe(int brojNarudzbe)
        {
            using (var db = new Entities())
            {
                var stavkeKosarice = from stavka in db.Stavka_kosarice
                                     join artikl in db.Artikls
                                     on stavka.Artikl_Id equals artikl.Artikl_Id
                                     where stavka.Kosarica_Id == kosarica.Kosarica_Id
                                     select new { ArtiklId = stavka.Artikl_Id, artikl.Cijena, artikl.Popust, stavka.Kolicina };
                
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
        //Ovom se funkcijom dohvaćaju potrebne informacije za izvještaj te se na kraju otvara izvještaj.
        //Prvo se deklariraju i alociraju potrebne varijable, a nakon toga se unutar konteksta dohvaća potrebna narudžba. 
        //Iz baze se dohvaćaju sve stavke tražene narudžbe te se dohvaća naziv stanja narudžbe.
        //Dohvaćaju se artikli koji odgovaraju stavkama narudžbe te potreban korisnik.
        //Zatim se otvara forma "frmIzvjestaj" koja sadrži popis stavaka i artikala, broj i stanje narudžbe, email, ime i prezime korisnika te na kraju oznaku
        // "1" ili "0 " s obzirom treba li se poslati PDF e-mailom.
        private void OtvoriIzvjestaj(int brojNarudzbe)
        {
            string imeKorisnika = "";

            Data.Stanje_narudzbe stanje = new Data.Stanje_narudzbe();
            Data.Narudzba narudzba = new Data.Narudzba();
            Data.Artikl artikl = new Data.Artikl();
            List<Data.Stavka_narudzbe> stavke = new List<Stavka_narudzbe>();
            List<Data.Stavka_narudzbe> stavka = new List<Data.Stavka_narudzbe>();
            List<Artikl> popis = new List<Artikl>();
            using (var entities = new Entities())
            {
                narudzba = entities.Narudzbas.First(X => X.Narudzba_Id == brojNarudzbe);
                int usporedba = int.Parse(narudzba.StanjeNarudzbe.ToString());
                stavka = entities.Stavka_narudzbe.Where(X => X.Narudzba_Id == brojNarudzbe).ToList();
                stanje = entities.Stanje_narudzbe.First(X => X.StanjeNarudzbe_Id == usporedba);
                foreach (Artikl ar in entities.Artikls)
                {
                    foreach (Stavka_narudzbe sta in stavka)
                    {
                        if (ar.Artikl_Id == sta.Artikl_Id)
                        {
                            popis.Add(ar);
                            stavke.Add(sta);
                        }
                    }
                }
                Korisnik korisnik = entities.Korisniks.First(k => k.Korisnik_Id == narudzba.KorisnikId);
                imeKorisnika = korisnik.Ime + " " + korisnik.Prezime;
            }

            FrmIzvjestaj forma = new FrmIzvjestaj(narudzba, popis, imeKorisnika, korisnik.Email, stavke, stanje.Naziv, 1);
            this.Hide();
            forma.ShowDialog();
            Close();
        }
    }

}
