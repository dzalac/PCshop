using PCShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
   public class StavkaNarudzbeOld
    {
        public int Kolicina { get; set; }

        public string Artikl { get; set; }

        public StavkaNarudzbeOld(int kolicina, Artikl artikl)
        {
            this.Kolicina = kolicina;
            this.Artikl =artikl.Proizvodac +" "+ artikl.Naziv;

        }
    }
}
