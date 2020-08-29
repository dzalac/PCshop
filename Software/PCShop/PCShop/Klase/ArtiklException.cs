using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
    class ArtiklException : PCShopExcepiton
    {
        public ArtiklException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
