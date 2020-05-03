using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
   public class StavkaNarudzbe
    {
        public int Kolicina { get; set; }

        public string Artikl { get; set; }

        public StavkaNarudzbe(int kolicina, Artikl artikl)
        {
            this.Kolicina = kolicina;
            this.Artikl =artikl.Proizvodac +" "+ artikl.Naziv;

        }
    }
}
