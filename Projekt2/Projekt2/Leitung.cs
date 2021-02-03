using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    class Leitung : Personal
    {
        public string LeitungID { get; }

        public Leitung(string LeitungID, string Name, string Vorname, DateTime Geburtsdatum, DateTime Einstellungsdatum, string Stellenbezeichnung, string Email, bool Verfuegbar) : base(Name, Vorname, Geburtsdatum, Einstellungsdatum, Stellenbezeichnung, Email, Verfuegbar)
        {
            this.LeitungID = LeitungID;
        }
    }
}
