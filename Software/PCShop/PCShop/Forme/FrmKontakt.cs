using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCShop.Forme
{
    public partial class FrmKontakt : Form
    {
        public FrmKontakt()
        {
            InitializeComponent();
        }

        private void FrmKontakt_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap("../../Slike/PcShopLogo.png");
            pbPCShop.Image = img;
        }

        private void FrmKontakt_KeyDown(object sender, KeyEventArgs e)
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
    }
}
