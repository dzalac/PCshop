using PCShop.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Data
{
    public partial class Artikl
    {
        private double? snizenaCijena;
        [NotMapped]

        public double? SnizenaCijena 
        { 
            get { return this.Cijena - (this.Cijena * this.Popust / 100); }
            set { snizenaCijena = value; } 
        }

        public Artikl(string naziv, double cijena, string proizvodac, string opis, int kolicina, int vrstaArtikla, double popust, DateTime datumDodavanja, byte[] slika)
        {

            Naziv = naziv;
            Cijena = cijena;
            Proizvodac = proizvodac;
            Opis = opis;
            Kolicina = kolicina;
            VrstaArtikla = vrstaArtikla;
            Popust = popust;
            DatumDodavanja = datumDodavanja;
            Slika = slika;
        }

    }

}
