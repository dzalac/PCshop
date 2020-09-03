using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string email;
        int saljiPdf = 0;
        public FrmIzvjestaj()
        {
            InitializeComponent();
        }
        public FrmIzvjestaj(Narudzba narudzba, List<Artikl> artikl, string korisnik, string email, List<Stavka_narudzbe> stavke, string stanje, int saljiPdf)
        {
            InitializeComponent();
            this.narudzba = narudzba;
            this.artikl = artikl;
            this.iznos = iznos * kolicina;
            this.korisnik = korisnik;
            this.stanje = stanje;
            this.stavke = stavke;
            this.email = email;
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


            //Ako je potrebno na e-mail poslati izvještaj u obliku PDF-a koristi se sljedeća funkcija
            //Metoda generiranja PDF-a i slanja na mail preuzeta je sa:
            //https://stackoverflow.com/questions/30168597/export-report-from-report-viewer-to-memory-stream-and-then-email-report
            //Izvještaj se pomoću funkcije Render pretvara u PDF oblik unutar memorije te se pomoću FileStream-a zapisuju podaci u polje bajtova.
            //Nakon toga se kreira novi MemoryStream iz polja bajtova koji se koristi kao parametar funkcije "PosaljiNarudzbenicu".
            if (saljiPdf == 1)
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = rvIzvjestaj.LocalReport.Render(
                   "PDF", null, out mimeType, out encoding, out filenameExtension,
                    out streamids, out warnings);


                string filename = Path.Combine(Environment.CurrentDirectory, "..\\..\\Izvjestaj\\Izvjestaj.rdlc");

                using (var fs = new FileStream(filename, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                }

                MemoryStream ms = new MemoryStream(bytes);
                EmailRukovanje.EmailRukovanje.PosaljiNarudzbenicu(ms, email);
            }
           
        }
    }
}
