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
using PCShop.Data;
using System.Collections.ObjectModel;

namespace PCShop
{
    public partial class FrmKosarica : Form
    {
        Kosarica kosarica;

        public FrmKosarica(Data.Kosarica trenutnaKosarica)
        {
            InitializeComponent();
            kosarica = trenutnaKosarica;
            Osvjezi();
        }
        public void Osvjezi()
        {
            using(var db = new Entities())
            {
                /*List<Stavka_kosarice> stavkeKosarice;
                stavkeKosarice = db.Stavka_kosarice.ToList();
                dgvKosarica.DataSource = null;
                dgvKosarica.DataSource = stavkeKosarice;
                dgvKosarica.Columns["Artikl"].Visible = false;
                dgvKosarica.Columns["Kosarica"].Visible = false;*/
                db.Kosaricas.Attach(kosarica);
                ICollection<Stavka_kosarice> stavkeKosarice = kosarica.Stavka_kosarice;
                ObservableCollection<Artikl> artikliUnutarKosarice = new ObservableCollection<Artikl>();
                foreach (var artikl in stavkeKosarice)
                {
                    artikliUnutarKosarice.Add(artikl.Artikl);
                }
                dgvKosarica.DataSource = null;
                dgvKosarica.DataSource = artikliUnutarKosarice;
                dgvKosarica.Columns["Stavka_kosarice"].Visible = false;
                dgvKosarica.Columns["Stavka_narudzbe"].Visible = false;
                dgvKosarica.Columns["Vrsta_artikla"].Visible = false;
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
            KosaricaOld.opcaKosarica.StavkeKosarice.Clear();
            Osvjezi();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvKosarica.CurrentRow != null)
            {
                Artikl selektiraniArtikl = dgvKosarica.CurrentRow.DataBoundItem as Artikl;
                if (selektiraniArtikl != null)
                {
                    using (var db = new Entities())
                    {
                        db.Artikls.Attach(selektiraniArtikl);
                        db.Artikls.Remove(selektiraniArtikl);
                        db.SaveChanges();
                    }

                }

            }
        
 
        }
        private void btnBlagajna_Click(object sender, EventArgs e)
        {
            FrmBlagajna form = new FrmBlagajna();
            Close();
            form.ShowDialog();
           
        }
    }
}
