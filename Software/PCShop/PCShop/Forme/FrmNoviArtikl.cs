﻿using PCShop.Data;
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
        private Artikl selektiraniArtikl;
        string lokacijaSlike = "";

        public FrmNoviArtikl(Artikl selektiraniArtikl)
        {
            InitializeComponent();
            this.selektiraniArtikl = selektiraniArtikl;
        }

        public FrmNoviArtikl()
        {
            InitializeComponent();
        }

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

        private void btnOdaberiSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            // dlg.Filter = "JPG FILES (*.jpg)|*.jpg|GIF Files (*.gif)|*gif|ALL Files (*.*)|*.*";
            //dlg.Title = "Odaberite sliku";
            dlg.Filter = "images|*.png";
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
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
                        Artikl noviArtikl = new Artikl(txtNaziv.Text, float.Parse(txtCijena.Text), txtProizvodac.Text, rtxtOpisArtikla.Text, int.Parse(txtKolicina.Text), (int)cbVrstaArtikla.SelectedValue, double.Parse(txtPopust.Text), dtpDatumDodavanja.Value, ms.ToArray());
                        /*{
                            Naziv = txtNaziv.Text,
                            Cijena = float.Parse(txtCijena.Text),
                            Proizvodac = txtProizvodac.Text,
                            Opis = rtxtOpisArtikla.Text,
                            Kolicina = int.Parse(txtKolicina.Text),
                            VrstaArtikla = (int)cbVrstaArtikla.SelectedValue,
                            Popust = float.Parse(txtPopust.Text),
                            DatumDodavanja = dtpDatumDodavanja.Value,
                            Slika = ms.ToArray()
                            };*/

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
            catch (ArtiklException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
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

        private void VerifikacijaUnosa()
        {
            //Verifikacija naziva
            if(string.IsNullOrEmpty(txtNaziv.Text))
            {
                throw new ArtiklException("Naziv proizvoda mora biti definiran.");
            }
            //Verifikacija proizvodaca
            if (string.IsNullOrEmpty(txtProizvodac.Text))
            {
                throw new ArtiklException("Naziv proizvođača mora biti definiran.");
            }
            //Verifikacija cijene
            double pomocnaVarijabla;
            int pomocnaVarijabla2;
            if (!double.TryParse(txtCijena.Text, out pomocnaVarijabla))
            {
                throw new ArtiklException("Cijena mora biti numeričke vrijednosti.");
            }
            else if (double.Parse(txtCijena.Text) < 0)
            {
                throw new ArtiklException("Cijena mora biti pozitivna.");
            }
            //Verifikacije kolicine
            if (!int.TryParse(txtKolicina.Text, out pomocnaVarijabla2))
            {
                throw new ArtiklException("Količina mora biti numeričke vrijednosti.");
            }
            else if (int.Parse(txtKolicina.Text) < 0)
            {
                throw new ArtiklException("Količina mora biti pozitivna.");
            }
            //Verifikacija popusta
            if (!double.TryParse(txtPopust.Text, out pomocnaVarijabla))
            {
                throw new ArtiklException("Popust mora biti numeričke vrijednosti.");
            }
            else if (double.Parse(txtPopust.Text) < 0)
            {
                throw new ArtiklException("Popust mora biti pozitivan.");
            }

            //Verifikacija opisa
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
