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
    
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            this.Narudzbas = new HashSet<Narudzba>();
        }
    
        public int Korisnik_Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public string PostanskiBroj { get; set; }
        public Nullable<int> Kosarica { get; set; }
        public Nullable<int> TipKorisnika { get; set; }
    
        public virtual Kosarica Kosarica1 { get; set; }
        public virtual Tip_korisnika Tip_korisnika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}