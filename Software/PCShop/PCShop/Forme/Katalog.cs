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

namespace PCShop
{
    public partial class FrmKatalog : Form
    {

        public static BindingList<Artikl> popis = new BindingList<Artikl>();
        public static BindingList<Artikl> snizeniProizvodi;
        public static BindingList<Artikl> pretraga;
        public static BindingList<Artikl> sortiranaLista;
        public static BindingList<Artikl> trenutniPopis;
        public static BindingList<Artikl> trazeniPopis;
        public FrmKatalog()
        {
            InitializeComponent();
        }
        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            rbtnPopust.Checked = true;
            popis.Add(new Artikl("GTX 1050", 1000, "NVIDIA", "Radni takt GPU [MHz] 1290, 2 GB", System.IO.Path.GetFullPath(@"..\..\Slike\GTX1050.png"), VrstaArtikla.graficka,25,0));
            popis.Add(new Artikl("Ryzen 3700", 500, "AMD", "The AMD Ryzen 7 3700X is a desktop processor with 8 cores, launched in July 2019. It is part of the Ryzen 7 lineup, using the Zen 2 (Matisse) architecture with Socket AM4.", System.IO.Path.GetFullPath(@"..\..\Slike\Ryzen3700.png"), VrstaArtikla.procesor, 25, 15));
            popis.Add(new Artikl("PC-21300", 400, "KINGSTON", "Kapacitet [GB] 4GB, Utor DDR4, Radni takt [MHz]2666 ", System.IO.Path.GetFullPath(@"..\..\Slike\PC-21300.png"), VrstaArtikla.ram, 50,10));
            popis.Add(new Artikl("WD8004FRYZ", 800, "WESTERN DIGITAL", "Sučelje: SATA3, Kapacitet diska [GB]: 8000, Brzina rotacije [okr./min.]: 7200, Cache [MB]: 256", System.IO.Path.GetFullPath(@"..\..\Slike\WD8004FRYZ.png"), VrstaArtikla.hdd,100, 0));
            popis.Add(new Artikl("X570", 1400, "ASROCK", "DDR4, ATX, s. AM4",  System.IO.Path.GetFullPath(@"..\..\Slike\X570.png"), VrstaArtikla.maticna,15,0));
            trenutniPopis = popis;
            Osvjezi(popis);
            UcitajSnizeneProizvode();
        }

        private void Osvjezi(BindingList<Artikl> lista)
        {
            dgvArtikli.DataSource = null;
            dgvArtikli.DataSource = lista;
        }



        public void TrazenaKategorija(VrstaArtikla vrsta)
        {
            trazeniPopis = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.VrstaArtikla == vrsta)
                    trazeniPopis.Add(artikl);
            }
            trenutniPopis = trazeniPopis;
            Osvjezi(trenutniPopis);
        }
        public void PromjenaLabele(string labela)
        {
            lblKorisnikoIme.Text = labela;
        }
        private void Sortiranje(BindingList<Artikl> lista, string opcija)
        {
            if (opcija == "Naziv/Uzlazno")
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
            }
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
            FrmArtikli frmArtikli = new FrmArtikli(odabraniArtikl);
            frmArtikli.ShowDialog();
        }
        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovo je kontakt firme:");
        }
        private void BtnTrazi_Click(object sender, EventArgs e)
        {
            pretraga = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.Naziv == txbPretraga.Text && pretraga.Contains(artikl) == false)
                {
                    pretraga.Add(artikl);
                }
            }
            trenutniPopis = pretraga;
            Osvjezi(pretraga);
        }
        private void BtnOsvjeziPopis_Click(object sender, EventArgs e)
        {

            Osvjezi(popis);
        }
        private void BtnSortCijenaUzlazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Cijena/Uzlazno";
            Sortiranje(trenutniPopis, sortiranje);
        }
        private void BtnSortCijenaSilazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Cijena/Silazno";
            Sortiranje(trenutniPopis, sortiranje);
        }
        private void BtnSortNazivUzlazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Naziv/Uzlazno";
            Sortiranje(trenutniPopis, sortiranje);
        }
        private void BtnSortNazivSilazno_Click(object sender, EventArgs e)
        {
            string sortiranje = "Naziv/Silazno";
            Sortiranje(trenutniPopis, sortiranje);
        }
        private void LblProcesori_Click(object sender, EventArgs e)
        {
            TrazenaKategorija(VrstaArtikla.procesor);
        }
        private void LblRadnaMemorija_Click(object sender, EventArgs e)
        {
            TrazenaKategorija(VrstaArtikla.ram);
        }
        private void LblTvrdiDiskovi_Click(object sender, EventArgs e)
        {
            TrazenaKategorija(VrstaArtikla.hdd);
        }
        private void LblMaticnePloce_Click(object sender, EventArgs e)
        {
            TrazenaKategorija(VrstaArtikla.maticna);
        }
        private void LblPC_Click(object sender, EventArgs e)
        {
            TrazenaKategorija(VrstaArtikla.prebuilt);
        }
        private void LblGrafickeKartice_Click(object sender, EventArgs e)
        {
            TrazenaKategorija(VrstaArtikla.graficka);
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
            snizeniProizvodi = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.Popust > 0 && snizeniProizvodi.Contains(artikl) == false)
                {
                    snizeniProizvodi.Add(artikl);
                }
            }
            dgvPosebna.DataSource = null;
            dgvPosebna.DataSource = snizeniProizvodi;
        }
        private void UcitajNoveProizvode()
        {
            snizeniProizvodi = new BindingList<Artikl>();
            foreach (Artikl artikl in popis)
            {
                if (artikl.DatumDodavanja < artikl.DatumDodavanja.AddDays(21) && snizeniProizvodi.Contains(artikl) == false)
                {
                    snizeniProizvodi.Add(artikl);
                }
            }
            dgvPosebna.DataSource = null;
            dgvPosebna.DataSource = snizeniProizvodi;
        }
    }

}