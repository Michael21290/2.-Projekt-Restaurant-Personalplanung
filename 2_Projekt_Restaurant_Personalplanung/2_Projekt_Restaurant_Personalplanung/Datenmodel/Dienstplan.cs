//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2_Projekt_Restaurant_Personalplanung.Datenmodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dienstplan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dienstplan()
        {
            this.Wochentag = new HashSet<Wochentag>();
        }
    
        public int ID_Dienstplan { get; set; }
        public Nullable<int> Kallenderwoche { get; set; }
        public Nullable<int> Jahr { get; set; }
        public string Personalgruppe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wochentag> Wochentag { get; set; }
    }
}
