using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
    class KorisnikException : PCShopExcepiton
    {
        public KorisnikException(string poruka)
        {
            this.Poruka = poruka;
        }
    }
}
