using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCShop.Forme;
using PCShop.Klase;

namespace PCShop
{
    public partial class FrmPrijava : Form
    {
        public static Korisnik korisnikAplikacije;
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
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            FrmKatalog forma = new FrmKatalog();
            bool pronadenKorisnik = false;
            foreach(Korisnik korisnik in FrmRegistracija.listaKorisnika) { 
                if(korisnik.KorisnickoIme == tbxKorisnickoIme.Text && korisnik.Lozinka == tbxLozinka.Text)
                {
                    korisnikAplikacije = korisnik;
                    MessageBox.Show("Uspješna prijava!");
                    Close();
                    pronadenKorisnik = true;
                }
            }
            if (pronadenKorisnik == false)
                MessageBox.Show("Vaš račun nije pronađen");
        }
    }
}
