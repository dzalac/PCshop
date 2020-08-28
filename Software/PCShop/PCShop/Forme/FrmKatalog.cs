using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using PCShop.Klase;
using PCShop.Forme;
using PCShop.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Collections.ObjectModel;

namespace PCShop
{
    public partial class FrmKatalog : Form
    {
        Entities entities = new Entities();
        /*
        public static BindingList<Artikl> popis = new BindingList<Artikl>();
        public static BindingList<Artikl> snizeniProizvodi;
        public static BindingList<Artikl> pretraga;
        public static BindingList<Artikl> sortiranaLista;
        public static BindingList<Artikl> trenutniPopis;
        public static BindingList<Artikl> trazeniPopis;*/
        public FrmKatalog()
        {
            InitializeComponent();
        }
        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            rbtnPopust.Checked = true;
            PrikaziArtikle();
            UcitajSnizeneProizvode();
        }
        private void PrikaziArtikle()
        {
            List<Artikl> artikli;
            artikli = entities.Artikls.ToList();
            dgvArtikli.DataSource = null;
            dgvArtikli.DataSource = artikli;
            dgvArtikli.Columns["Stavka_kosarice"].Visible = false;
            dgvArtikli.Columns["Stavka_narudzbe"].Visible = false;
            dgvArtikli.Columns["Vrsta_artikla"].Visible = false;
        }

        /*public void TrazenaKategorija(VrstaArtikla vrsta)
        {
            trazeniPopis = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.VrstaArtikla == vrsta)
                    trazeniPopis.Add(artikl);
            }
            trenutniPopis = trazeniPopis;
            Osvjezi(trenutniPopis);
        }*/
        public void PromjenaLabele(string labela)
        {
            lblKorisnikoIme.Text = labela;
        }
        private void Sortiranje(BindingList<Artikl> lista, string opcija)
        {
            /*if (opcija == "Naziv/Uzlazno")
            {
                sortiranaLista = new BindingList<Artikl>(lista.OrderBy(artikl => artikl.Naziv).ToList());
                Osvjezi(sortiranaLista);
            }

            if (opcija == "Naziv/Silazno")
            {
                sortiranaLista = new BindingList<Artikl>(lista.OrderByDescending(artikl => artikl.Naziv).ToList());
                Osvjezi(sortiranaLista);
            }

            if (opcija == "Cijena/Uzlazno")
            {
                sortiranaLista = new BindingList<Artikl>(lista.OrderBy(artikl => artikl.Cijena).ToList());
                Osvjezi(sortiranaLista);
            }

            if (opcija == "Cijena/Silazno")
            {
                sortiranaLista = new BindingList<Artikl>(lista.OrderByDescending(artikl => artikl.Cijena).ToList());
                Osvjezi(sortiranaLista);
            }*/
        }
        private void BtnKosarica_Click(object sender, EventArgs e)
        {
            FrmKosarica frmKosarica = new FrmKosarica();
            frmKosarica.ShowDialog();
        }
        private void BtnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija frmRegistracija = new FrmRegistracija();
            frmRegistracija.ShowDialog();
        }
        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            FrmPrijava frmPrijava = new FrmPrijava();
            frmPrijava.ShowDialog();
        }
        private void BtnOtvoriArtikl_Click(object sender, EventArgs e)
        {
            Artikl odabraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
            //FrmArtikli frmArtikli = new FrmArtikli(odabraniArtikl);
           // frmArtikli.ShowDialog();
        }
        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovo je kontakt firme:");
        }
        private void BtnTrazi_Click(object sender, EventArgs e)
        {
            /*pretraga = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.Naziv == txbPretraga.Text && pretraga.Contains(artikl) == false)
                {
                    pretraga.Add(artikl);
                }
            }
            trenutniPopis = pretraga;
            Osvjezi(pretraga);*/
        }
        private void BtnOsvjeziPopis_Click(object sender, EventArgs e)
        {

            //Osvjezi(popis);
        }
        private void BtnSortCijenaUzlazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Cijena/Uzlazno";
           // Sortiranje(trenutniPopis, sortiranje);
        }
        private void BtnSortCijenaSilazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Cijena/Silazno";
            //Sortiranje(trenutniPopis, sortiranje);
        }
        private void BtnSortNazivUzlazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Naziv/Uzlazno";
            //Sortiranje(trenutniPopis, sortiranje);
        }
        private void BtnSortNazivSilazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Naziv/Silazno";
            //Sortiranje(trenutniPopis, sortiranje);
        }
        private void LblProcesori_Click(object sender, EventArgs e)
        {
            //TrazenaKategorija(VrstaArtikla.procesor);
        }
        private void LblRadnaMemorija_Click(object sender, EventArgs e)
        {
            //TrazenaKategorija(VrstaArtikla.ram);
        }
        private void LblTvrdiDiskovi_Click(object sender, EventArgs e)
        {
            //TrazenaKategorija(VrstaArtikla.hdd);
        }
        private void LblMaticnePloce_Click(object sender, EventArgs e)
        {
           // TrazenaKategorija(VrstaArtikla.maticna);
        }
        private void LblPC_Click(object sender, EventArgs e)
        {
           // TrazenaKategorija(VrstaArtikla.prebuilt);
        }
        private void LblGrafickeKartice_Click(object sender, EventArgs e)
        {
           // TrazenaKategorija(VrstaArtikla.graficka);
        }
        private void FrmKatalog_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            if(e.KeyValue == 112)
            {
                string helpFile = System.IO.Path.GetFullPath(@"..\..\Korisnicka_dokumentacija.chm");

                if (System.IO.File.Exists(helpFile))
                {
                    Help.ShowHelp(this, helpFile);
                }
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtnPopust_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPopust.Checked)
            {
                UcitajSnizeneProizvode();
            }
            else
            {
                UcitajNoveProizvode();
            }
        }

        private void UcitajSnizeneProizvode()
        {
            var group = from artikl in entities.Artikls.Local where artikl.Popust>0 select artikl;
            ObservableCollection<Artikl> result = new ObservableCollection<Artikl>();
            foreach (var item in group)
            {
                result.Add(item);
            }
           
            dgvPosebna.DataSource = result;
            dgvPosebna.Columns["Stavka_kosarice"].Visible = false;
            dgvPosebna.Columns["Stavka_narudzbe"].Visible = false;
            dgvPosebna.Columns["Vrsta_artikla"].Visible = false;
        }
        private void UcitajNoveProizvode()
        {
            double brojDana = 21;
            var granicniDatum = DateTime.Now.AddDays(-brojDana);
            var group = from artikl in entities.Artikls.Local where artikl.DatumDodavanja > granicniDatum select artikl;
            ObservableCollection<Artikl> result = new ObservableCollection<Artikl>();
            foreach (var item in group)
            {
               result.Add(item);
            }
            dgvPosebna.DataSource = result;
            dgvPosebna.Columns["Stavka_kosarice"].Visible = false;
            dgvPosebna.Columns["Stavka_narudzbe"].Visible = false;
            dgvPosebna.Columns["Vrsta_artikla"].Visible = false;
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeArtiklima frmUpravljanjeArtiklima = new FrmUpravljanjeArtiklima(entities);
            frmUpravljanjeArtiklima.ShowDialog();
            PrikaziArtikle();
        }
    }

}