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
    }
}
