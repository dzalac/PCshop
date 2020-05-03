using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{

    public class Narudzba
    {
        public int BrojNarudzbe { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public string AdresaDostave { get; set; }
        public double Iznos { get; set; }
        public List<Artikl> StavkeNarudzbe { get; set; }
        public string NacinPlacanja { get; set; }
        public string BrojRacuna { get; set; }
        public int KontrolniBroj { get; set; }

        public Narudzba(int brojnarudzbe, DateTime datumNarudzbe, string adresadostave, double iznos, List<Artikl> stavkenarudzbe, string nacinplacanja, string brojracuna, int kontrolnibroj)
        {
            this.BrojNarudzbe = brojnarudzbe;
            this.DatumNarudzbe = datumNarudzbe;
            this.AdresaDostave = adresadostave;
            this.StavkeNarudzbe = stavkenarudzbe;
            this.NacinPlacanja = nacinplacanja;
            this.BrojRacuna = brojracuna;
            this.KontrolniBroj = kontrolnibroj;
            this.Iznos = iznos;
        }
    }

}
