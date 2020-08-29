using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
    public class KosaricaOld
    {
        public DateTime DatumKreriranja { get; set; }
        public BindingList<StavkaNarudzbe> StavkeKosarice { get; set; } = new BindingList<StavkaNarudzbe>();

        public KosaricaOld()
        {
            DatumKreriranja = DateTime.Now.Date;
        }
        public static KosaricaOld opcaKosarica = new KosaricaOld();
    }
      
}
