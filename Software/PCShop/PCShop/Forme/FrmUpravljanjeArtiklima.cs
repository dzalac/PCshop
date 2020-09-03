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
    public partial class FrmUpravljanjeArtiklima : Form
    {
     
        public FrmUpravljanjeArtiklima()
        {
            InitializeComponent();
        }

        private void FrmUpravljanjeArtiklima_Load(object sender, EventArgs e)
        {
            PrikaziArtikle();
        }

        //Iz konteksta se povlači lista artikala te se prikazuje na DataGridView-u.
        private void PrikaziArtikle()
        {
            using(var entities = new Entities())
            {
                List<Artikl> artikli;
                artikli = entities.Artikls.ToList();
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                dgvArtikli.Columns["Stavka_kosarice"].Visible = false;
                dgvArtikli.Columns["Stavka_narudzbe"].Visible = false;
                dgvArtikli.Columns["Vrsta_artikla"].Visible = false;
            }

           
        }

        private void lblDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmNoviArtikl frmNoviArtikl = new FrmNoviArtikl();
            frmNoviArtikl.ShowDialog();
            PrikaziArtikle();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Odabrani redak se pretvara u objekt tipa "Artikl"
        //Artikl se kači na kontekst i zatim se otvara forma za kreiranje novog artikla koja se koristi za izmjenu.
        //Lista se osvježava.
        private void lblUrediArtikl_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.CurrentRow != null)
            {
                Artikl selektiraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                if (selektiraniArtikl != null)
                {
                    FrmNoviArtikl noviArtikl = new FrmNoviArtikl(selektiraniArtikl);
                    noviArtikl.ShowDialog();
                    PrikaziArtikle();
                }

            }
            
        }

        //Odabrani redak se pretvara u objekt tipa "Artikl"
        //Artikl se kači na kontekst i zatim se briše iz baze podataka te se promjene spremaju.
        private void lblIzbrisiArtikl_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.CurrentRow != null)
            {
                Artikl selektiraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                if (selektiraniArtikl != null)
                {
                    using(var db = new Entities())
                    {
                        db.Artikls.Attach(selektiraniArtikl);
                        db.Artikls.Remove(selektiraniArtikl);
                        db.SaveChanges();
                    }
                    PrikaziArtikle();
                }
               
            }
        }

        private void FrmUpravljanjeArtiklima_KeyDown(object sender, KeyEventArgs e)
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
