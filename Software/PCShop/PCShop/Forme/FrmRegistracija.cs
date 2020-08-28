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

namespace PCShop
{
    public partial class FrmRegistracija : Form
    {
        public static BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
        public FrmRegistracija()
        {
            InitializeComponent();
        }
        public void RegistracijaKorisnika()
        {       
            if(tbxLozinka.Text == tbxPotvrdaLozinka.Text)
            {  
                listaKorisnika.Add(new Korisnik(tbxIme.Text, tbxPrezime.Text, tbxMail.Text, tbxKorisnickoIme.Text, tbxGrad.Text, tbxAdresa.Text, int.Parse(tbxPostanskiBroj.Text), tbxLozinka.Text));
                MessageBox.Show("Uspješna registracija!");
                Close();
            }
            else
            {
                MessageBox.Show("Lozinke se ne podudaraju!");
            }
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
            RegistracijaKorisnika();
        }
    }
}
