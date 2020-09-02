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
    public partial class FrmPregledNarudzbi : Form
    {
        Korisnik korisnik;
        public FrmPregledNarudzbi(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void FrmPregledNarudzbi_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();   
        }

        private void PrikazNarudzbi()
        {
            using(var db = new Entities())
            {
                var listaNarudzbi = from narudzba in db.Narudzbas
                                    join stanje in db.Stanje_narudzbe
                                    on narudzba.StanjeNarudzbe equals stanje.StanjeNarudzbe_Id
                                    where narudzba.KorisnikId == korisnik.Korisnik_Id
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

        private void PrikazArtikala(int selektiranaNarudzba)
        {
            using(var db = new Entities())
            {
                var listaArtikala = from artikl in db.Artikls
                                    join stavka in db.Stavka_narudzbe
                                    on artikl.Artikl_Id equals stavka.Artikl_Id
                                    where stavka.Narudzba_Id == selektiranaNarudzba
                                    select new { ArtiklId = stavka.Artikl_Id, Naziv = artikl.Naziv, Kolicina = stavka.Kolicina };
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = listaArtikala.ToList();
            }
        }

        private void dgvNarudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNarudzbe.SelectedRows.Count > 0)
            {
                var selektiraniRed= dgvNarudzbe.CurrentRow;
                int selektiranaNarudzba = (int)selektiraniRed.Cells[0].Value;
                PrikazArtikala(selektiranaNarudzba);
            }
        }

        private void dgvNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNarudzbe.SelectedRows.Count > 0)
            {
                var selektiraniRed = dgvNarudzbe.CurrentRow;
                int selektiranaNarudzba = (int)selektiraniRed.Cells[0].Value;
                PrikazArtikala(selektiranaNarudzba);
            }
        }

        private void lblOtkaziNarudzbu_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var selektiraniRed = dgvNarudzbe.CurrentRow;
                int selektiranaNarudzba = (int)selektiraniRed.Cells[0].Value;
                Narudzba narudzba = db.Narudzbas.First(n => n.Narudzba_Id == selektiranaNarudzba);
                if(narudzba.StanjeNarudzbe == 2)
                {
                    MessageBox.Show("Narudžba je već otkazana.");
                }
                else if(narudzba.StanjeNarudzbe == 4)
                {
                    MessageBox.Show("Narudžba je već dostavljena.");
                }
                else
                {
                    db.Narudzbas.Attach(narudzba);
                    narudzba.StanjeNarudzbe = 2;
                    db.SaveChanges();
                    MessageBox.Show("Narudžba je uspješno otkazana.");
                    PrikazNarudzbi();
                }
                
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
