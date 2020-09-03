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
        private readonly Narudzba narudzba;
        private readonly List<Artikl> artikl;
        private readonly List<Stavka_narudzbe> stavke;

        readonly string korisnik;
        readonly string stanje;
        readonly string email;
        readonly int saljiPdf = 0;
        public FrmIzvjestaj()
        {
            InitializeComponent();
        }
        public FrmIzvjestaj(Narudzba narudzba, List<Artikl> artikl, string korisnik, string email, List<Stavka_narudzbe> stavke, string stanje, int saljiPdf)
        {
            InitializeComponent();
            this.narudzba = narudzba;
            this.artikl = artikl;
            this.korisnik = korisnik;
            this.stanje = stanje;
            this.saljiPdf = saljiPdf;
            this.stavke = stavke;
            this.email = email;
        }
        //Pri pokretanju forme učitvaju se u nju poslani objekti i varijable odabrane narudžbenice, postavlja se datasource i dodaju se varijable u parametre reportviewera
        private void FrmIzvjestaj_Load(object sender, EventArgs e)
        {

            List<Narudzba> narudzbas = new List<Narudzba>
            {
                narudzba
            };
            //datasource
            var rds = new ReportDataSource("NarudzbaDataSet", narudzbas);
            var rds2 = new ReportDataSource("ArtiklDataSet", artikl);
            var rds3 = new ReportDataSource("StavkaNarudzbeDataSet", stavke);

            this.rvIzvjestaj.LocalReport.DataSources.Clear();
            this.rvIzvjestaj.LocalReport.DataSources.Add(rds);
            this.rvIzvjestaj.LocalReport.DataSources.Add(rds2);
            this.rvIzvjestaj.LocalReport.DataSources.Add(rds3);
            //parametri
            this.rvIzvjestaj.LocalReport.SetParameters(new ReportParameter("Korisnik", korisnik.ToString()));
            this.rvIzvjestaj.LocalReport.SetParameters(new ReportParameter("StanjeNarudzbe", stanje.ToString()));
            this.rvIzvjestaj.RefreshReport();


            //Ako je potrebno na e-mail poslati izvještaj u obliku PDF-a koristi se sljedeća funkcija
            //Metoda generiranja PDF-a i slanja na mail preuzeta je sa:
            //https://stackoverflow.com/questions/30168597/export-report-from-report-viewer-to-memory-stream-and-then-email-report
            //Izvještaj se pomoću funkcije Render pretvara u PDF oblik unutar memorije te se pomoću FileStream-a zapisuju podaci u polje bajtova.
            //Nakon toga se kreira novi MemoryStream iz polja bajtova koji se koristi kao parametar funkcije "PosaljiNarudzbenicu".
            if (saljiPdf == 1)
            {
                byte[] bytes = rvIzvjestaj.LocalReport.Render(
                       "PDF", null, out _, out _, out _,
                        out _, warnings: out _);


                string sourceFile = Path.Combine(Environment.CurrentDirectory, "..\\..\\Izvjestaj\\Izvjestaj.rdlc");
                string destinationFile = Path.Combine(Environment.CurrentDirectory, "..\\..\\Izvjestaj\\Izvjestaj2.rdlc");

                // To move a file or folder to a new location:
                System.IO.File.Copy(sourceFile, destinationFile);

                string filename = Path.Combine(Environment.CurrentDirectory, "..\\..\\Izvjestaj\\Izvjestaj2.rdlc");

                using (var fs = new FileStream(filename, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                }

                MemoryStream ms = new MemoryStream(bytes);
                EmailRukovanje.EmailRukovanje.PosaljiNarudzbenicu(ms, email);
                System.IO.File.Delete(Path.Combine(Environment.CurrentDirectory, "..\\..\\Izvjestaj\\Izvjestaj2.rdlc"));
            }
           
        }

        private void FrmIzvjestaj_KeyDown(object sender, KeyEventArgs e)
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
