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
        public double Cijena { get; set; }
        public string Proizvodac { get; set; }
        public string Opis { get; set; }
        public bool PosebnaPonuda { get; set; }
        public string Slika { get; set; }
        public VrstaArtikla VrstaArtikla { get; set; }
        
        public Artikl(string naziv, double cijena, string proizvodac, string opis, bool posebnaPonuda, string slika, VrstaArtikla vrstaArtikla)
        {
            this.Naziv = naziv;
            this.Cijena = cijena;
            this.Proizvodac = proizvodac;
            this.Opis = opis;
            this.PosebnaPonuda = posebnaPonuda;
            this.Slika = slika;
            this.VrstaArtikla = vrstaArtikla;
        }
    }
}
