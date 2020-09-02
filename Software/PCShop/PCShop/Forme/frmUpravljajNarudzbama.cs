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

namespace PCShop.Forme
{
    public partial class frmUpravljajNarudzbama : Form
    {
        public frmUpravljajNarudzbama()
        {
            InitializeComponent();
        }

        private void frmUpravljajNarudzbama_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
        }

        private void PrikazNarudzbi()
        {
            using (var db = new Entities())
            {
                var listaNarudzbi = from narudzba in db.Narudzbas
                                    join stanje in db.Stanje_narudzbe
                                    on narudzba.StanjeNarudzbe equals stanje.StanjeNarudzbe_Id
                                    select new
                                    {
                                        NarudzbaId = narudzba.Narudzba_Id,
                                        DatumNarudzbe = narudzba.DatumNarudzbe,
                                        Grad = narudzba.GradDostave,
                                        Adresa = narudzba.AdresaDostave,
                                        PostanskiBroj = narudzba.PostanskiBroj,
                                        StanjeNarudzbe = stanje.Naziv
                                    };
                dgvNarudzbe.DataSource = null;
                dgvNarudzbe.DataSource = listaNarudzbi.ToList();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPoslano_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var selektiraniRed = dgvNarudzbe.CurrentRow;
                int selektiranaNarudzba = (int)selektiraniRed.Cells[0].Value;
                Narudzba narudzba = db.Narudzbas.First(n => n.Narudzba_Id == selektiranaNarudzba);
                if (narudzba.StanjeNarudzbe == 2)
                {
                    MessageBox.Show("Narudžba je već otkazana.");
                }
                else if(narudzba.StanjeNarudzbe == 3)
                {
                    MessageBox.Show("Narudžba je već poslana.");
                }
                else if (narudzba.StanjeNarudzbe == 4)
                {
                    MessageBox.Show("Narudžba je već dostavljena.");
                }
                else
                {
                    db.Narudzbas.Attach(narudzba);
                    narudzba.StanjeNarudzbe = 3;
                    db.SaveChanges();
                    MessageBox.Show("Narudžba je poslana.");
                    PrikazNarudzbi();
                }

            }
        }

        private void btnDostavljeno_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var selektiraniRed = dgvNarudzbe.CurrentRow;
                int selektiranaNarudzba = (int)selektiraniRed.Cells[0].Value;

                Narudzba narudzba = db.Narudzbas.First(n => n.Narudzba_Id == selektiranaNarudzba);
                if (narudzba.StanjeNarudzbe == 1)
                {
                    MessageBox.Show("Narudžba mora biti prvo poslana.");
                }
                else if (narudzba.StanjeNarudzbe == 2)
                {
                    MessageBox.Show("Narudžba je već otkazana.");
                }
                else if (narudzba.StanjeNarudzbe == 4)
                {
                    MessageBox.Show("Narudžba je već dostavljena.");
                }
                else
                {
                    db.Narudzbas.Attach(narudzba);
                    narudzba.StanjeNarudzbe = 4;
                    db.SaveChanges();
                    MessageBox.Show("Narudžba je dostavljena.");
                    PrikazNarudzbi();
                }

            }
        }
    }
}
