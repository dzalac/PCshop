using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
    public class Kosarica
    {
        public DateTime DatumKreriranja { get; set; }
        public BindingList<StavkaNarudzbe> StavkeKosarice { get; set; } = new BindingList<StavkaNarudzbe>();

        public Kosarica()
        {
            DatumKreriranja = DateTime.Now.Date;
        }
        public static Kosarica opcaKosarica = new Kosarica();
    }
      
}
