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
    public partial class FrmBlagajna : Form
    {
        public FrmBlagajna()
        {
            InitializeComponent();
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
            MessageBox.Show("Kupnja je obavljena!");
            Kosarica.opcaKosarica.StavkeKosarice.Clear();
            Close();
        }
    }
}
