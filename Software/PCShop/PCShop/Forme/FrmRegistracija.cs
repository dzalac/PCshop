﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCShop.Data;
using PCShop.Klase;

namespace PCShop
{
    public partial class FrmRegistracija : Form
    {
       // public static BindingList<Korisnik> listaKorisnika = new BindingList<Korisnik>();
        public FrmRegistracija()
        {
            InitializeComponent();
        }
     
        private void FrmRegistracija_KeyDown(object sender, KeyEventArgs e)
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
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

       //Ako je su svi podaci ispravno unesneni, kreira se novi korisnik pomoću tih podataka.
       //Kako je svaki korisnik koji se registrira tipa "Korisnik", atribut "TipKorisnika" postavlja se na vrijednost 2 (adminstratoru odgovara vrijednost 1).
       //Novome se korisniku kreira košarica koja je povezana s korisničkim računom pomoću njegovog Id-a.
       //Uspješnom registracijom ispisuje se poruka i šalje se e-mail obavijest.
        private void BtnRegistriraj_Click(object sender, EventArgs e)
        {
            int vrstaKorisnika = 2;
            try
            {
                VerifikacijaUnosa();
                using(var db = new Entities())
                {
                    Korisnik noviKorisnik = new Korisnik
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Email = txtMail.Text,
                        Grad = txtGrad.Text,
                        Adresa = txtAdresa.Text,
                        PostanskiBroj = txtPostanskiBroj.Text,
                        Lozinka = txtLozinka.Text,
                        TipKorisnika = vrstaKorisnika
                    };
                    db.Korisniks.Add(noviKorisnik);
                    db.SaveChanges();

                    Kosarica novaKosarica = new Data.Kosarica
                    {
                        DatumKreiranja = DateTime.Now,
                        Korisnik = noviKorisnik.Korisnik_Id
                    };
                    db.Kosaricas.Add(novaKosarica);
                    db.SaveChanges();
                    EmailRukovanje.EmailRukovanje.PosaljiObavijestORegistraciji(noviKorisnik.Email, noviKorisnik.KorisnickoIme);
                }
                MessageBox.Show("Uspješna registracija! Možete se prijaviti.");
                Close();
            }
            catch (KorisnikException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

      
        private void VerifikacijaUnosa()
        {
            //Verifikacija imena
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                throw new KorisnikException("Ime mora biti navedeno.");
            }
            //Verifikacija prezimena
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                throw new KorisnikException("Prezime mora biti navedeno.");
            }
            //Verifikacija korisnickog imena
            //Ako je polje prazno, baca se iznimka.
            //Provjerava se je li korisničko ime zauzeto. Ako je, baca se iznimka.
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                throw new KorisnikException("Korisničko ime mora biti navedeno.");
            }
            else
            {
                using (var db = new Entities())
                {
                    var korisnickoIme = txtKorisnickoIme.Text;
                    ObservableCollection<Korisnik> result = new ObservableCollection<Data.Korisnik>();
                    foreach (var item in db.Korisniks)
                    {
                        if (item.KorisnickoIme == korisnickoIme)
                            result.Add(item);
                    }
                    if (result.Count > 0)
                    {
                        throw new KorisnikException("Korisničko ime je zauzeto.");
                    }
                }
            }


            //Verifikacija e-maila pomoću regularnog izraza. U slučaju da se vrati vrijednost "false", baca se nova iznimka.
           string mailUzorak = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                + "@"
                                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            if(!Regex.IsMatch(txtMail.Text,mailUzorak))
            {
                throw new KorisnikException("Email nije ispravnog formata.");
            }
            else
            {
                using (var db = new Entities())
                {
                    var email = txtMail.Text;
                    ObservableCollection<Korisnik> result = new ObservableCollection<Data.Korisnik>();
                    foreach (var item in db.Korisniks)
                    {
                        if (item.Email == email)
                            result.Add(item);
                    }
                    if (result.Count > 0)
                    {
                        throw new KorisnikException("Email se već koristi.");
                    }
                }
            }

            //Verifikacija naziva grada
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtGrad.Text))
            {
                throw new KorisnikException("Naziv grada mora biti definiran.");
            }
            //Verifikacija adrese stanovanja
            //Ako je polje prazno, baca se iznimka.
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                throw new KorisnikException("Adresa stanovanja mora biti definirana.");
            }
            //Verifikacija poštanskog broja
            //Ako je polje prazno, baca se iznimka.
            //U slučaju da polje ne sadrži vrijednost tipa "int", baca se iznimka.
            if (string.IsNullOrEmpty(txtPostanskiBroj.Text))
            {
                throw new KorisnikException("Poštanski broj mora biti definiran.");
            }
            else if(!int.TryParse(txtPostanskiBroj.Text,out _) || txtPostanskiBroj.Text.Length<5)
            {
                throw new KorisnikException("Poštanski broj mora biti napisan u ispravnom formatu.");
            }
            //Verifikacija lozinke
            //Ako je polje prazno, baca se iznimka.
            //Ako se lozinka i potvrda lozinke ne poklapaju, baca se iznimka.
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                throw new KorisnikException("Lozinka mora biti definirana.");
            }
            else if(txtLozinka.Text != txtPotvrdaLozinka.Text)
            {
                throw new KorisnikException("Lozinke se moraju podudarati.");
            }

        }

    }
}
