using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Projekt_Restaurant_Personalplanung.Modelle
{
    public class Personalplan
    {
        public string Kalenderwoche { get; set; }
        public string ErstelltVon { get; set; }
        public string Personalgruppe { get; set; }
        public virtual List<Mitarbeiter> ID_Mitarbeiter { get; set; }
    }
}
