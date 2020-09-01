using PCShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCShop.Klase;

namespace PCShop.Forme
{
    public partial class FrmKorisnik : Form
    {
        readonly Korisnik korisnik;
        public FrmKorisnik(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void FrmKorisnik_Load(object sender, EventArgs e)
        {
            tbxIme.Text = korisnik.Ime;
            tbxPrezime.Text = korisnik.Prezime;
            tbxAdresa.Text = korisnik.Adresa;
            tbxMail.Text = korisnik.Email;
            tbxPostanskiBroj.Text = korisnik.PostanskiBroj;
            tbxGrad.Text = korisnik.Grad;
            lblKorisnickoIme.Text = korisnik.KorisnickoIme;
        }

        private void BtnIzmjeni_Click(object sender, EventArgs e)
        {
            
           try
           {
                using (var entities = new Entities())
                {
                    VerifikacijaUnosa();
                    entities.Korisniks.Attach(korisnik);
                    korisnik.Ime = tbxIme.Text;
                    korisnik.Prezime = tbxPrezime.Text;
                    korisnik.Grad = tbxGrad.Text;
                    korisnik.PostanskiBroj = tbxPostanskiBroj.Text;
                    korisnik.Email = tbxMail.Text;
                    korisnik.Adresa = tbxAdresa.Text;
                    if(lblPromjenaLozinke.Visible == false)
                    {
                        korisnik.Lozinka = tbxPotvrdaLozinka.Text;
                    }
                    entities.SaveChanges();
                }
                Close();
           }
           catch (KorisnikException ex)
           {
               MessageBox.Show(ex.Poruka);
           }
        }

        private void LblZaboravljenaLozinka_Click(object sender, EventArgs e)
        {
            lblNovaLozinka.Visible = true;
            lblPotvrdaLozinka.Visible = true;
            lblStaraLozinka.Visible = true;
            tbxNovaLozinka.Visible = true;
            tbxStaraLozinka.Visible = true;
            tbxPotvrdaLozinka.Visible = true;
            lblPromjenaLozinke.Visible = false;
        }

        private void VerifikacijaUnosa()
        {
            //Verifikacija imena
            if (string.IsNullOrEmpty(tbxIme.Text))
            {
                throw new KorisnikException("Ime korisnika mora biti definirano.");
            }
            //Verifikacija prezimena
            if (string.IsNullOrEmpty(tbxPrezime.Text))
            {
                throw new KorisnikException("Prezime korisnika mora biti definirano.");
            }
            //Verifikacija grada
            if (string.IsNullOrEmpty(tbxGrad.Text))
            {
                throw new KorisnikException("Informacija o gradu korisnika mora biti definirana.");
            }
            //Verifikacije kolicine
            if (string.IsNullOrEmpty(tbxAdresa.Text))
            {
                throw new KorisnikException("Informacija o adresi korisnika mora biti definirana.");
            }
            //Verifikacije postanskog broja
            if (string.IsNullOrEmpty(tbxPostanskiBroj.Text))
            {
                throw new KorisnikException("Informacija o poštanskom broju korisnika mora biti definirana.");
            }
            //Verifikacije maila
            if (string.IsNullOrEmpty(tbxMail.Text))
            {
                throw new KorisnikException("E-mail adresa korisnika mora biti definirana.");
            }
            if (lblPromjenaLozinke.Visible == false) { 
                if(tbxStaraLozinka.Text != korisnik.Lozinka)
                {
                    throw new KorisnikException("Krivo upisana stara lozinka!");
                }
                if(tbxNovaLozinka.Text != tbxPotvrdaLozinka.Text)
                {
                    throw new KorisnikException("Nova lozinka se ne poklapa sa potvrdom");
                }
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
