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
    
    public partial class Mitarbeiter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mitarbeiter()
        {
            this.Benutzeraccount = new HashSet<Benutzeraccount>();
            this.MitarbeiterSchicht = new HashSet<MitarbeiterSchicht>();
        }
    
        public int ID_Mitarbeiter { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public Nullable<System.DateTime> Geburtsdatum { get; set; }
        public Nullable<System.DateTime> Einstellungsdatum { get; set; }
        public string Stellenbezeichnung { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IstVerfügbar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Benutzeraccount> Benutzeraccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MitarbeiterSchicht> MitarbeiterSchicht { get; set; }
    }
}
