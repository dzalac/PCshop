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
    
    public partial class Kosarica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kosarica()
        {
            this.Korisniks = new HashSet<Korisnik>();
            this.Stavka_kosarice = new HashSet<Stavka_kosarice>();
        }
    
        public int kosarica_id { get; set; }
        public Nullable<System.DateTime> datum_kreairanja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisniks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_kosarice> Stavka_kosarice { get; set; }
    }
}
