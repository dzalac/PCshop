using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Data
{
    public partial class Podaci_o_placanju
    {
        public Podaci_o_placanju(int brojNarudzbe, int nacinPlacanja)
        {
            this.BrojNarudzbe = brojNarudzbe;
            this.NacinPlacanja = nacinPlacanja;
        }
        public Podaci_o_placanju()
        {

        }
    }
}
