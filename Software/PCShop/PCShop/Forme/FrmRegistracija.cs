using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCShop.Data;
using PCShop.Klase;

namespace PCShop
{
    public partial class FrmRegistracija : Form
    {
       // public static BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
        public FrmRegistracija()
        {
            InitializeComponent();
        }
     
        private void FrmRegistracija_KeyDown(object sender, KeyEventArgs e)
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

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            int vrstaKorisnika = 2;
            try
            {
                VerifikacijaUnosa();
                using(var db = new Entities())
                {
                    Korisnik noviKorisnik = new Korisnik
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Email = txtMail.Text,
                        Grad = txtGrad.Text,
                        Adresa = txtAdresa.Text,
                        PostanskiBroj = txtPostanskiBroj.Text,
                        Lozinka = txtLozinka.Text,
                        TipKorisnika = vrstaKorisnika
                    };
                    db.Korisniks.Add(noviKorisnik);

                    int korisnikId = 0;
                    var upit = from korisnik in db.Korisniks where korisnik.KorisnickoIme == txtKorisnickoIme.Text select korisnik;
                    foreach (var item in upit)
                    {
                        korisnikId = item.Korisnik_Id;
                    }

                    Kosarica novaKosarica = new Data.Kosarica
                    {
                        DatumKreiranja = DateTime.Now,
                        Korisnik = korisnikId
                    };
                    db.Kosaricas.Add(novaKosarica);
                    db.SaveChanges();
                }

                MessageBox.Show("Uspješna registracija! Možete se prijaviti.");
                Close();
            }
            catch (KorisnikException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

      
        private void VerifikacijaUnosa()
        {
            //Verifikacija imena
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                throw new KorisnikException("Ime mora biti navedeno.");
            }
            //Verifikacija prezimena
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                throw new KorisnikException("Prezime mora biti navedeno.");
            }
            //Verifikacija korisnickog imena
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                throw new KorisnikException("Korisničko ime mora biti navedeno.");
            }
            else
            {
                using (var db = new Entities())
                {
                    var korisnickoIme = txtKorisnickoIme.Text;
                    ObservableCollection<Korisnik> result = new ObservableCollection<Data.Korisnik>();
                    foreach (var item in db.Korisniks)
                    {
                        if (item.KorisnickoIme == korisnickoIme)
                            result.Add(item);
                    }
                    if (result.Count > 0)
                    {
                        throw new KorisnikException("Korisničko ime je zauzeto.");
                    }
                }
            }


            //Verifikacija e-maila pomoću regularnog izraza
           string mailUzorak = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                + "@"
                                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            if(!Regex.IsMatch(txtMail.Text,mailUzorak))
            {
                throw new KorisnikException("Email nije ispravnog formata.");
            }

            //Verifikacija naziva grada
            if (string.IsNullOrEmpty(txtGrad.Text))
            {
                throw new KorisnikException("Naziv grada mora biti definiran.");
            }
            //Verifikacija adrese stanovanja
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                throw new KorisnikException("Adresa stanovanja mora biti definirana.");
            }
            //Verifikacija poštanskog broja
            int pomocnaVarijabla;
            if (string.IsNullOrEmpty(txtPostanskiBroj.Text))
            {
                throw new KorisnikException("Poštanski broj mora biti definiran.");
            }
            else if(!int.TryParse(txtPostanskiBroj.Text,out pomocnaVarijabla) || txtPostanskiBroj.Text.Length<5)
            {
                throw new KorisnikException("Poštanski broj mora biti napisan u ispravnom formatu.");
            }
            //Verifikacija lozinke
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                throw new KorisnikException("Lozinka mora biti definirana.");
            }
            else if(txtLozinka.Text != txtPotvrdaLozinka.Text)
            {
                throw new KorisnikException("Lozinke se moraju podudarati.");
            }

        }
        
    }
}
