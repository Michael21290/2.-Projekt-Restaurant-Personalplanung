using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    abstract class Personal
    {
        public string ID { get; }
        public string Name { get; set; }
        public string Vorname { get; set; }

        public DateTime Geburtsdatum = new DateTime();

        public DateTime Einstellungsdatum = new DateTime();

        public string Stellenbezeichnung { get; set; }
        public string Email { get; set; }
        public bool Verfuegbar { get; set; }

        public Personal(string Name, string Vorname, DateTime Geburtsdatum, DateTime Einstellungsdatum, string Stellenbezeichnung, string Email, bool Verfuegbar)
        {
            this.Name = Name;
            this.Vorname = Vorname;
            this.Geburtsdatum = Geburtsdatum;
            this.Einstellungsdatum = Einstellungsdatum;
            this.Stellenbezeichnung = Stellenbezeichnung;
            this.Email = Email;
            this.Verfuegbar = Verfuegbar;
        }
    }
}
