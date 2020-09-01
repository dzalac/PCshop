using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
    class BlagajnaException : PCShopException
    {
        public BlagajnaException(string poruka)
        {
            this.Poruka = poruka;
        }
    }
}
