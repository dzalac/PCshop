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
using PCShop.Forme;

namespace PCShop
{
    public partial class FrmKosarica : Form
    {
        public static BindingList<StavkaNarudzbe> kosarica = new BindingList<StavkaNarudzbe>();

        public FrmKosarica()
        {
            InitializeComponent();
            Osvjezi();
        }
        public void Osvjezi()
        {
            dgvKosarica.DataSource = null;
            dgvKosarica.DataSource = Kosarica.opcaKosarica.StavkeKosarice.ToList() ;
        }
        public void ObrisiArtikl()
        {
            StavkaNarudzbe korisnikovaKosarica = dgvKosarica.CurrentRow.DataBoundItem as StavkaNarudzbe;
            if (Kosarica.opcaKosarica.StavkeKosarice.Contains(korisnikovaKosarica))
            {
                Kosarica.opcaKosarica.StavkeKosarice.Remove(korisnikovaKosarica);
            }
        }
        private void FrmKosarica_KeyDown(object sender, KeyEventArgs e)
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
        private void btnOcistiKosaricu_Click(object sender, EventArgs e)
        {
            Kosarica.opcaKosarica.StavkeKosarice.Clear();
            Osvjezi();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ObrisiArtikl();
            Osvjezi();     
        }
        private void btnBlagajna_Click(object sender, EventArgs e)
        {
            FrmBlagajna form = new FrmBlagajna();
            Close();
            form.ShowDialog();
           
        }
    }
}
