//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stavka_kosarice
    {
        public int kosarica_id { get; set; }
        public int artikl_id { get; set; }
        public int kolicina { get; set; }
    
        public virtual Artikl Artikl { get; set; }
        public virtual Kosarica Kosarica { get; set; }
    }
}
