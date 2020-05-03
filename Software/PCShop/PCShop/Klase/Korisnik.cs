using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
   public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public int PostanskiBroj { get; set; }
        public string Lozinka { get; set; }
        public Kosarica Kosarica { get; set; }
        public List<Narudzba> Narudzbe { get; set; }

        public Korisnik(string ime, string prezime, string email, string korisnickoIme, string grad, string adresa, int postanskiBroj, string lozinka)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.KorisnickoIme = korisnickoIme;
            this.Grad = grad;
            this.Adresa = adresa;
            this.PostanskiBroj = postanskiBroj;
            this.Lozinka = lozinka;
        }


    }
}
