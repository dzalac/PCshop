using PCShop.Data;
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
        Entities entities;
        private Artikl selektiraniArtikl;

        public FrmNoviArtikl(Artikl selektiraniArtikl, Entities entities)
        {
            InitializeComponent();
            this.selektiraniArtikl = selektiraniArtikl;
            this.entities = entities;
        }

        public FrmNoviArtikl(Entities entities)
        {
            this.entities = entities;
            InitializeComponent();
        }

        private ObservableCollection<Vrsta_artikla> DohvatiVrsteArtikala()
        {
            var group = from vrsta in entities.Vrsta_artikla select vrsta;
            ObservableCollection<Vrsta_artikla> result = new ObservableCollection<Vrsta_artikla>();
            foreach (var item in group)
            {
                result.Add(item);
            }
            return result;
        }

        private void btnOdaberiSliku_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "images|*.png";
            openFileDialog1.ShowDialog();
            if(openFileDialog1.CheckFileExists)
            {
                pbSlika.Load(openFileDialog1.FileName);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
           using (entities)
            {
                MemoryStream ms = new MemoryStream();
                pbSlika.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                if(selektiraniArtikl == null)
                {
                    Artikl noviArtikl = new Artikl
                    {
                        Cijena = double.Parse(txtCijena.Text),
                        DatumDodavanja = dtpDatumDodavanja.Value,
                        Kolicina = int.Parse(txtKolicina.Text),
                        Naziv = txtNaziv.Text,
                        Opis = rtxtOpisArtikla.Text,
                        Popust = double.Parse(txtPopust.Text),
                        Proizvodac = txtProizvodac.Text,
                        VrstaArtikla = (int)cbVrstaArtikla.SelectedValue,
                        Slika = ms.ToArray()
                    };
                    entities.Artikls.Add(noviArtikl);
                    entities.SaveChanges();
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
                    entities.SaveChanges();
                }
            }
            Close();
        }

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
    }
}
