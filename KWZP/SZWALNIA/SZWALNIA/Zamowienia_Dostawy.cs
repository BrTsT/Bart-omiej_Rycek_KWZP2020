//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SZWALNIA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zamowienia_Dostawy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienia_Dostawy()
        {
            this.Dostarczenia_Wewn = new HashSet<Dostarczenia_Wewn>();
            this.Dostawy_Zawartosc = new HashSet<Dostawy_Zawartosc>();
            this.Zawartosc = new HashSet<Zawartosc>();
        }
    
        public int ID_Dostawy { get; set; }
        public Nullable<int> ID_Zamowienia { get; set; }
        public Nullable<System.DateTime> Data_Dostawy_Planowana { get; set; }
        public Nullable<System.DateTime> Data_Dostawy_Rzeczywista { get; set; }
        public Nullable<int> ID_statusu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostarczenia_Wewn> Dostarczenia_Wewn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostawy_Zawartosc> Dostawy_Zawartosc { get; set; }
        public virtual Statusy Statusy { get; set; }
        public virtual Zamowienia Zamowienia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zawartosc> Zawartosc { get; set; }
    }
}