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
    public partial class FrmUpravljajNarudzbama : Form
    {
        public FrmUpravljajNarudzbama()
        {
            InitializeComponent();
        }

        private void FrmUpravljajNarudzbama_Load(object sender, EventArgs e)
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
                                        narudzba.DatumNarudzbe,
                                        Grad = narudzba.GradDostave,
                                        Adresa = narudzba.AdresaDostave,
                                        narudzba.PostanskiBroj,
                                        StanjeNarudzbe = stanje.Naziv
                                    };
                dgvNarudzbe.DataSource = null;
                dgvNarudzbe.DataSource = listaNarudzbi.ToList();
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Pomoću Id-a odabrane narudžbe u DataGridView-u dohvaća se narudžba i provjerava joj se stanje.
        //Ako je moguće, narudžba se deklarira poslanom tako da se odabrana narudžba kvači na kontekst i mijenja joj se stanje u "U dostavi".
        //Sprema se promjena i ispisuje se poruka.
        private void BtnPoslano_Click(object sender, EventArgs e)
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
        //Pomoću Id-a odabrane narudžbe u DataGridView-u dohvaća se narudžba i provjerava joj se stanje.
        //Ako je moguće, narudžba se deklarira dostavljenom tako da se odabrana narudžba kvači na kontekst i mijenja joj se stanje u "Dostavljeno".
        //Sprema se promjena i ispisuje se poruka.
        private void BtnDostavljeno_Click(object sender, EventArgs e)
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
