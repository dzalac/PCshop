﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Klase
{
    public abstract class PCShopExcepiton : ApplicationException
    {
        public string Poruka { get; set; }

    }
}
