using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
    public enum VrstaArtikla { procesor, graficka, maticna, hdd, ram, prebuilt};
    public class Artikl
    {
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string Proizvodac { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }
        public VrstaArtikla VrstaArtikla { get; set; }
        public int Kolicina { get; set; }
        public float Popust { get; set; }

        public float SnizenaCijena { get; set; }

        public DateTime DatumDodavanja { get; set; }

        public Artikl(string naziv, float cijena, string proizvodac, string opis, string slika, VrstaArtikla vrstaArtikla, int kolicina, float popust)
        {
            this.Naziv = naziv;
            this.Cijena = cijena;
            this.Proizvodac = proizvodac;
            this.Opis = opis;    
            this.Slika = slika;
            this.VrstaArtikla = vrstaArtikla;
            this.Kolicina = kolicina;
            this.Popust = popust;
            this.DatumDodavanja = DateTime.Now;
            this.SnizenaCijena = cijena - cijena * popust / 100;
        }
    }
}
