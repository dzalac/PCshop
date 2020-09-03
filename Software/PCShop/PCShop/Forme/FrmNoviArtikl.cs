using PCShop.Data;
using PCShop.Klase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCShop.Forme
{
    public partial class FrmNoviArtikl : Form
    {
        //Entities entities;
        private readonly Artikl selektiraniArtikl;

        public FrmNoviArtikl(Artikl selektiraniArtikl)
        {
            InitializeComponent();
            this.selektiraniArtikl = selektiraniArtikl;
        }

        public FrmNoviArtikl()
        {
            InitializeComponent();
        }

        //Funkcija dohvaća popis vrsta artikala
        private ObservableCollection<Vrsta_artikla> DohvatiVrsteArtikala()
        {
            using(var entities = new Entities())
            {
                var group = from vrsta in entities.Vrsta_artikla select vrsta;
                ObservableCollection<Vrsta_artikla> result = new ObservableCollection<Vrsta_artikla>();
                foreach (var item in group)
                {
                    result.Add(item);
                }
                return result;
            }
        }

        //Otvara se novi dijalog kojim se mogu birati samo slike tipa ".png". Ako je rezultat dijaloga OK, slika se učitava; u suprotnom,
        //ispisuje se poruka da slika mora biti izabrana.
        private void BtnOdaberiSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "images|*.png"
            };
            var rezultat = dlg.ShowDialog();
            if (rezultat==DialogResult.OK)
            {   
                pbSlika.Load(dlg.FileName);
            }
            else if(rezultat == DialogResult.Cancel)
            {
                MessageBox.Show("Slika mora biti izabrana!");
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Provjerava se unos u poljima; ako postoji greška ispisuje se poruka na ekranu.
        //Kreira se novi tok memorije za rad sa slikama. Slika se sprema u tok memorije.
        //Ako je forma učitana na način da se izmjenjuje postojeći artikl, artikl se kači na konekst i spremaju se promjene,
        //inače se kreira novi artikl koji se dodaje u bazu podataka i sprema se novi zapis u bazi.
        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var entities = new Entities())
                {
                    VerifikacijaUnosa();
                    MemoryStream ms = new MemoryStream();
                    pbSlika.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    if (selektiraniArtikl == null)
                    {
                        Artikl noviArtikl = new Artikl//new Artikl(txtNaziv.Text, float.Parse(txtCijena.Text), txtProizvodac.Text, rtxtOpisArtikla.Text, int.Parse(txtKolicina.Text), (int)cbVrstaArtikla.SelectedValue, double.Parse(txtPopust.Text), dtpDatumDodavanja.Value, ms.ToArray());
                        {
                            Naziv = txtNaziv.Text,
                            Cijena = float.Parse(txtCijena.Text),
                            Proizvodac = txtProizvodac.Text,
                            Opis = rtxtOpisArtikla.Text,
                            Kolicina = int.Parse(txtKolicina.Text),
                            VrstaArtikla = (int)cbVrstaArtikla.SelectedValue,
                            Popust = float.Parse(txtPopust.Text),
                            DatumDodavanja = dtpDatumDodavanja.Value,
                            Slika = ms.ToArray()
                        };
                        entities.Artikls.Add(noviArtikl);
                    }
                    else
                    {
                        entities.Artikls.Attach(selektiraniArtikl);
                        selektiraniArtikl.Naziv = txtNaziv.Text;
                        selektiraniArtikl.Kolicina = int.Parse(txtKolicina.Text);
                        selektiraniArtikl.Opis = rtxtOpisArtikla.Text;
                        selektiraniArtikl.Popust = double.Parse(txtPopust.Text);
                        selektiraniArtikl.Proizvodac = txtProizvodac.Text;
                        selektiraniArtikl.Slika = ms.ToArray();
                        selektiraniArtikl.VrstaArtikla = (int)cbVrstaArtikla.SelectedValue;
                        selektiraniArtikl.DatumDodavanja = dtpDatumDodavanja.Value;
                    }
                    entities.SaveChanges();
                }
                Close();
            }
            catch (ArtiklException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
        //Postavljaju se oznake i vrijednosti padajuće liste za izbor vrsta artikala koji se dohvaćaju funkcijom "DohvatiVrsteArtikala".
        //Ako je forma učitana pomoću preopterećanja funkcije za otvaranje forme koja uzima za argument artikl, polja u formi se popunjavaju.
        private void FrmNoviArtikl_Load(object sender, EventArgs e)
        {
            cbVrstaArtikla.DisplayMember = "Naziv";
            cbVrstaArtikla.ValueMember = "VrstaArtikla_Id";
            cbVrstaArtikla.DataSource = DohvatiVrsteArtikala();
            if(selektiraniArtikl != null)
            {
                txtCijena.Text = selektiraniArtikl.Cijena.ToString();
                txtKolicina.Text = selektiraniArtikl.Kolicina.ToString();
                txtNaziv.Text = selektiraniArtikl.Naziv;
                txtPopust.Text = selektiraniArtikl.Popust.ToString();
                txtProizvodac.Text = selektiraniArtikl.Proizvodac;
                dtpDatumDodavanja.Value = selektiraniArtikl.DatumDodavanja.Value;
                MemoryStream ms = new MemoryStream((byte[])selektiraniArtikl.Slika);
                var image = Image.FromStream(ms);
                pbSlika.Image = image;
                rtxtOpisArtikla.Text = selektiraniArtikl.Opis;
            }
        }

        private void VerifikacijaUnosa()
        {
            //Verifikacija naziva
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                throw new ArtiklException("Naziv proizvoda mora biti definiran.");
            }
            //Verifikacija proizvodaca
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtProizvodac.Text))
            {
                throw new ArtiklException("Naziv proizvođača mora biti definiran.");
            }
            //Verifikacija cijene
            //U slučaju da polje ne sadrži vrijednost tipa "double", baca se iznimka.
            //Ako je vrijednost manja od 0, baca se iznimka.
            if (!double.TryParse(txtCijena.Text, out _))
            {
                throw new ArtiklException("Cijena mora biti numeričke vrijednosti.");
            }
            else if (double.Parse(txtCijena.Text) < 0)
            {
                throw new ArtiklException("Cijena mora biti pozitivna.");
            }
            //Verifikacije kolicine
            //U slučaju da polje ne sadrži vrijednost tipa "int", baca se iznimka.
            //Ako je vrijednost manja od 0, baca se iznimka.
            if (!int.TryParse(txtKolicina.Text, out _))
            {
                throw new ArtiklException("Količina mora biti numeričke vrijednosti.");
            }
            else if (int.Parse(txtKolicina.Text) < 0)
            {
                throw new ArtiklException("Količina mora biti pozitivna.");
            }
            //Verifikacija popusta
            //U slučaju da polje ne sadrži vrijednost tipa "double", baca se iznimka.
            //Ako je vrijednost manja od 0, baca se iznimka.
            if (!double.TryParse(txtPopust.Text, out _))
            {
                throw new ArtiklException("Popust mora biti numeričke vrijednosti.");
            }
            else if (double.Parse(txtPopust.Text) < 0)
            {
                throw new ArtiklException("Popust mora biti pozitivan.");
            }

            //Verifikacija opisa
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(rtxtOpisArtikla.Text))
            {
                throw new ArtiklException("Opis proizvoda mora biti definiran.");
            }
            //Verifikacija slike
            if (pbSlika.Image == null)
            {
                throw new ArtiklException("Slika mora biti izabrana.");
            }
        }
    }
}
