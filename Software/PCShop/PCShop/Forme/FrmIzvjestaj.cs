using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PCShop.Data;

namespace PCShop.Forme
{
    public partial class FrmIzvjestaj : Form
    { 
        private Narudzba narudzba;
        private List<Artikl> artikl;
        private List<Stavka_narudzbe> stavke;

        double iznos;

        int kolicina;

        string korisnik;
        string stanje;
        public FrmIzvjestaj()
        {
            InitializeComponent();
        }
        public FrmIzvjestaj(Narudzba narudzba, List<Artikl> artikl, string korisnik, List<Stavka_narudzbe> stavke, string stanje)
        {
            InitializeComponent();
            this.narudzba = narudzba;
            this.artikl = artikl;
            this.iznos = iznos * kolicina;
            this.korisnik = korisnik;
            this.stanje = stanje;
            this.stavke = stavke;
        }
        private void FrmIzvjestaj_Load(object sender, EventArgs e)
        {

            List<Narudzba> narudzbas = new List<Narudzba>();
            //List<Artikl> artikls = new List<Artikl>();
            narudzbas.Add(narudzba);
            // artikls.Add(artikl);
            //datasource
            var rds = new ReportDataSource("NarudzbaDataSet", narudzbas);
            var rds2 = new ReportDataSource("ArtiklDataSet", artikl);
            var rds3 = new ReportDataSource("StavkaNarudzbeDataSet", stavke);

            this.rvIzvjestaj.LocalReport.DataSources.Clear();
            this.rvIzvjestaj.LocalReport.DataSources.Add(rds);
            this.rvIzvjestaj.LocalReport.DataSources.Add(rds2);
            this.rvIzvjestaj.LocalReport.DataSources.Add(rds3);
            //parametri
            // var total = (from o in order.Order_Details
            //  select o.Quantity * o.UnitPrice).Sum();
            //  this.reportViewer1.LocalReport.SetParameters(new ReportParameter("IznosKn", iznos.ToString()));
            this.rvIzvjestaj.LocalReport.SetParameters(new ReportParameter("Korisnik", korisnik.ToString()));
            //  this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Kolicina", );
            this.rvIzvjestaj.LocalReport.SetParameters(new ReportParameter("StanjeNarudzbe", stanje.ToString()));
            this.rvIzvjestaj.RefreshReport();
        }
    }
}
