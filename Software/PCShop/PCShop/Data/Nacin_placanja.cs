//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCShop.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nacin_placanja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nacin_placanja()
        {
            this.Podaci_o_placanju = new HashSet<Podaci_o_placanju>();
        }
    
        public int NacinPlacanja_Id { get; set; }
        public string Naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podaci_o_placanju> Podaci_o_placanju { get; set; }
    }
}