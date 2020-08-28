using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCShop.Data;
using PCShop.Forme;
using PCShop.Klase;

namespace PCShop.Forme
{
    public partial class FrmArtikli : Form
    {
        public Artikl artikl;
        public FrmArtikli(Artikl unosArtikl)
        {
            InitializeComponent();
            artikl = unosArtikl;
            Osvjezi(artikl);
        }

        public void Osvjezi(Artikl artikl)
        {
            lblNaziv.Text = artikl.Naziv;
            lblCijena.Text = artikl.Cijena.ToString();
            if (artikl.Popust>0)
            {
                lblCijena.ForeColor = System.Drawing.Color.Red;
                lblSnizenaCijena.Text = artikl.SnizenaCijena.ToString();
                lblSnizenaCijena.Visible = true;
            }
            
            rtbxOpis.Text = artikl.Opis;
            MemoryStream ms = new MemoryStream((byte[])artikl.Slika);
            pbSlika.Image = Image.FromStream(ms);
            
        }

        private void LblCijena_Click(object sender, EventArgs e)
        {
                       
        }

        private void FrmArtikl_KeyDown(object sender, KeyEventArgs e)
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int kolicina = int.Parse(tbxKolicina.Text);
            if (tbxKolicina.Text != "")
            {
                // Kosarica.opcaKosarica.StavkeKosarice.Add(new StavkaNarudzbe(kolicina, artikl));
            }
            MessageBox.Show("Artikl je dodan u košaricu");
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmArtikli_Load(object sender, EventArgs e)
        {

        }
    }
}
