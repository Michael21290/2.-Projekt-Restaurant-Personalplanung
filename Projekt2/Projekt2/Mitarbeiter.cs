using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    class Mitarbeiter : Personal
    {
        public string MitarbeiterID { get; }

        public Mitarbeiter(string MitarbeiterID, string Name, string Vorname, DateTime Geburtsdatum, DateTime Einstellungsdatum, string Stellenbezeichnung, string Email, bool Verfuegbar): base (Name,Vorname,Geburtsdatum,Einstellungsdatum,Stellenbezeichnung,Email,Verfuegbar)
        {
            this.MitarbeiterID = MitarbeiterID;
        }

            

    }
}
