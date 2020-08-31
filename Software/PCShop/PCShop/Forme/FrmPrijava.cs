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
using PCShop.Forme;
using PCShop.Klase;

namespace PCShop
{
    public partial class FrmPrijava : Form
    {
        public Korisnik Korisnik { get; set; }

        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void FrmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
            {
                string helpFile = System.IO.Path.GetFullPath(@"..\..\helper.chm");

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

        //Upitom se dohvaća korisnik čija lozinka i korisničko ime odgovara onom unesenom u tekstnim poljima.
        //Ako korisnik ne postoji, tj. vrijednost je null, ispisuje se poruka greške.
        //Međutim, ako korisnik postoji ispisuje se poruka uspješne prijave i rezultat forme je OK.
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var upit = from korisnik in db.Korisniks where korisnik.Lozinka == txtLozinka.Text && korisnik.KorisnickoIme == txtKorisnickoIme.Text select korisnik;
                foreach (var item in upit)
                {
                    if(item!=null)
                    {
                        Korisnik = new Korisnik();
                        Korisnik = item;
                    }
                }
                if(Korisnik==null)
                {
                    MessageBox.Show("Prijava neuspješna! Provjerite ispravnost korisničkog imena i lozinke.");
                }
                else
                {
                    MessageBox.Show($"Uspješna prijava! Pozdrav, {Korisnik.Ime} {Korisnik.Prezime}");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }

            }
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
