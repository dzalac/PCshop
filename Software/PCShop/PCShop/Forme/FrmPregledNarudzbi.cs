﻿using PCShop.Data;
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
        readonly Korisnik korisnik;
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

        private void PrikazArtikala(int selektiranaNarudzba)
        {
            using(var db = new Entities())
            {
                var listaArtikala = from artikl in db.Artikls
                                    join stavka in db.Stavka_narudzbe
                                    on artikl.Artikl_Id equals stavka.Artikl_Id
                                    where stavka.Narudzba_Id == selektiranaNarudzba
                                    select new { ArtiklId = stavka.Artikl_Id, artikl.Naziv, stavka.Kolicina };
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = listaArtikala.ToList();
            }
        }

        private void DgvNarudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNarudzbe.SelectedRows.Count > 0)
            {
                var selektiraniRed= dgvNarudzbe.CurrentRow;
                int selektiranaNarudzba = (int)selektiraniRed.Cells[0].Value;
                PrikazArtikala(selektiranaNarudzba);
            }
        }

        private void DgvNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNarudzbe.SelectedRows.Count > 0)
            {
                var selektiraniRed = dgvNarudzbe.CurrentRow;
                int selektiranaNarudzba = (int)selektiraniRed.Cells[0].Value;
                PrikazArtikala(selektiranaNarudzba);
            }
        }


        //Pomoću Id-a odabrane narudžbe u DataGridView-u dohvaća se narudžba i provjerava joj se stanje.
        //Ako je moguće, narudžba se otkazuje tako da se odabrana narudžba kvači na kontekst i mijenja joj se stanje da odgovara otkazanom.
        //Sprema se promjena i ispisuje se poruka.
        private void LblOtkaziNarudzbu_Click(object sender, EventArgs e)
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

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Ovom se funkcijom dohvaćaju potrebne informacije za izvještaj te se na kraju otvara izvještaj.
        //Prvo se deklariraju i alociraju potrebne varijable, a nakon toga se unutar konteksta dohvaća potrebna narudžba. 
        //Iz baze se dohvaćaju sve stavke tražene narudžbe te se dohvaća naziv stanja narudžbe.
        //Dohvaćaju se artikli koji odgovaraju stavkama narudžbe te potreban korisnik.
        //Zatim se otvara forma "frmIzvjestaj" koja sadrži popis stavaka i artikala, broj i stanje narudžbe, email, ime i prezime korisnika te na kraju oznaku
        // "1" ili "0 " s obzirom treba li se poslati PDF e-mailom.
        private void BtnPregled_Click(object sender, EventArgs e)
        {
            int brojNarudzbe = int.Parse(dgvNarudzbe.CurrentRow.Cells[0].Value.ToString());
            string imeKorisnika = "";

            Data.Stanje_narudzbe stanje = new Data.Stanje_narudzbe();
            Data.Narudzba narudzba = new Data.Narudzba();
            Data.Artikl artikl = new Data.Artikl();
            List<Data.Stavka_narudzbe> stavke = new List<Stavka_narudzbe>();
            List<Data.Stavka_narudzbe> stavka = new List<Data.Stavka_narudzbe>();
            List<Artikl> popis = new List<Artikl>();
            using (var entities = new Entities())
            {
                narudzba = entities.Narudzbas.First(X => X.Narudzba_Id == brojNarudzbe);
                int usporedba = int.Parse(narudzba.StanjeNarudzbe.ToString());
                stavka = entities.Stavka_narudzbe.Where(X => X.Narudzba_Id == brojNarudzbe).ToList();
                stanje = entities.Stanje_narudzbe.First(X => X.StanjeNarudzbe_Id == usporedba);
                foreach (Artikl ar in entities.Artikls)
                {
                    foreach (Stavka_narudzbe sta in stavka)
                    {
                        if (ar.Artikl_Id == sta.Artikl_Id)
                        {
                            popis.Add(ar);
                            stavke.Add(sta);
                        }
                    }
                }
                Korisnik korisnik = entities.Korisniks.First(k => k.Korisnik_Id == narudzba.KorisnikId);
                imeKorisnika = korisnik.Ime + " " + korisnik.Prezime;
            }

            FrmIzvjestaj forma = new FrmIzvjestaj(narudzba, popis, imeKorisnika,korisnik.Email, stavke, stanje.Naziv,0);
            forma.ShowDialog();
        }

        private void FrmPregledNarudzbi_KeyDown(object sender, KeyEventArgs e)
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
