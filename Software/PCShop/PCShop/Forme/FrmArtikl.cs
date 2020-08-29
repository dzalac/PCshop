using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using PCShop.Forme;
namespace PCShop
{
    public partial class FrmArtikl : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=PI20_011_DB; User ID=PI20_011_User; Password=g{+EKZ99");
        SqlCommand naredba;
        SqlDataReader dr;

        private PictureBox slika;
        private string oznaka;
        public FrmArtikl(string tag)
        {
            InitializeComponent();
            oznaka = tag;
        }

        private void FrmArtikl_Load(object sender, EventArgs e)
        {
            conn.Open();
            naredba = new SqlCommand("SELECT slika,artikl_id,cijena,naziv,opis FROM Artikl WHERE artikl_id = " + oznaka, conn);
            dr = naredba.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pbSlika.BackgroundImage = bitmap;
                pbSlika.BackgroundImageLayout = ImageLayout.Stretch;

                rtbxOpis.Text = dr["opis"].ToString();
                lblCijena.Text = dr["cijena"].ToString();
                lblNaziv.Text = dr["naziv"].ToString();

            }
            dr.Close();
            conn.Close();
        }
    }
}
