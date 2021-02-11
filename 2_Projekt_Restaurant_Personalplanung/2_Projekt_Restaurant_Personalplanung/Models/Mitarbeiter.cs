using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Projekt_Restaurant_Personalplanung.Modelle
{
    public class Mitarbeiter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public DateTime Einstellungsdatum { get; set; }
        public string Stellenbezeichnung { get; set; }
        public string Email { get; set; }
        public bool IstVerfuegbar { get; set; }
        public virtual Benutzeraccount ID_BenutzerAccount { get; set; }
        public virtual List<Dienstplan> Dienstpläne { get; set; }
    }
}
