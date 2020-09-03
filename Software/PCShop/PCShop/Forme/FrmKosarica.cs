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
        readonly Kosarica kosarica;
        private readonly Korisnik trenutniKorisnik;

        public FrmKosarica(Data.Kosarica trenutnaKosarica,Korisnik trenutniKorisnik)
        {
            InitializeComponent();
            kosarica = trenutnaKosarica;
            this.trenutniKorisnik = trenutniKorisnik;
        }


        //Pomocu join funkcije se spajaju tablice "Artikli" i "Stavka_kosarice" gdje odgovaraju Id-u košarice.
        //Rezultati upita se koriste kao izvor podataka za DataGridView.
        public void Osvjezi()
        {
            using(var db = new Entities())
            {
                db.Kosaricas.Attach(kosarica);
                var data = from stavka in db.Stavka_kosarice
                           join artikl in db.Artikls
                           on stavka.Artikl_Id equals artikl.Artikl_Id
                           where stavka.Kosarica_Id == kosarica.Kosarica_Id && kosarica.Korisnik == trenutniKorisnik.Korisnik_Id
                           select new 
                           { 
                               ArtiklId = stavka.Artikl_Id,
                               artikl.Naziv,
                               stavka.Kolicina, 
                               JedinicnaCijena = (artikl.Cijena - artikl.Cijena * artikl.Popust / 100), 
                               UkupnaCijena = ((artikl.Cijena - artikl.Cijena * artikl.Popust / 100) * stavka.Kolicina)};
               
                dgvKosarica.DataSource = null;
                dgvKosarica.DataSource = data.ToList();
                double? ukupnaVrijednost = 0;
                foreach (var item in data.ToList())
                {
                    ukupnaVrijednost += item.UkupnaCijena;
                }
                lblUkupniIznos.Text = ukupnaVrijednost + "kn";
                var postojeStavke = db.Stavka_kosarice.FirstOrDefault(stavka => stavka.Kosarica_Id == kosarica.Kosarica_Id);
                if (postojeStavke != null)
                {
                    btnBlagajna.Enabled = true;
                    btnObrisi.Enabled = true;
                    btnOcistiKosaricu.Enabled = true;
                }
                else
                {
                    btnBlagajna.Enabled = false;
                    btnObrisi.Enabled = false;
                    btnOcistiKosaricu.Enabled = false;
                }
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
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Unutar konteksta se pomoću upita dohvaćaju sve stavke košarice.
        //Nakon toga se iterirajući kroz listu stavaka, svaka pojedina stavka kači na kontekst i uklanja iz baze podataka. Nakon završenog brisanja
        //promjene se spremaju i osvježava se DataGridView.
        private void BtnOcistiKosaricu_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var stavkeKosarice = from stavka in db.Stavka_kosarice where stavka.Kosarica_Id == kosarica.Kosarica_Id select stavka;
                foreach (var stavka in stavkeKosarice)
                {
                    db.Stavka_kosarice.Attach(stavka);
                    db.Stavka_kosarice.Remove(stavka);
                }
                db.SaveChanges();
            }
            Osvjezi();
        }
        
        //Ako je odabrani redak u DataGridView-u različit od null, iz retka se uzima vrijednost prvog stupca u kojemu se nalazi Id artikla.
        //Pomoću tog Id-a se dohvaća stavka s odgovarajućim Id-om koja pripada košarici korisnika te se kači na konteskt i briše iz baze podataka, 
        //a promjene se spremaju.
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvKosarica.CurrentRow != null)
            {
                var selektiraniArtikl = dgvKosarica.CurrentRow;
                if (selektiraniArtikl != null)
                {
                    var idArtikla = (int)selektiraniArtikl.Cells[0].Value;
                    using (var db = new Entities())
                    {
                        Stavka_kosarice stavka = db.Stavka_kosarice.First(s => s.Artikl_Id == idArtikla && s.Kosarica_Id == kosarica.Kosarica_Id);
                        db.Stavka_kosarice.Attach(stavka);
                        db.Stavka_kosarice.Remove(stavka);
                        db.SaveChanges();
                    }
                }
            }
            Osvjezi();
        }
        private void BtnBlagajna_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmBlagajna form = new FrmBlagajna(trenutniKorisnik,kosarica);
            form.ShowDialog();
            Close();

        }

        private void FrmKosarica_Load(object sender, EventArgs e)
        {
              Osvjezi();
        }
    }
}
