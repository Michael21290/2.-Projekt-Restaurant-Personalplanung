using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Projekt_Restaurant_Personalplanung.Modelle
{
    public class Benutzeraccount
    {
        public int ID { get; set; }
        public string Benutzername { get; set; }
        public string Passwort { get; set; }
        public bool IstAdmin { get; set; }
        public virtual Mitarbeiter ID_Mitarbeiter { get; set; }
    }
}
