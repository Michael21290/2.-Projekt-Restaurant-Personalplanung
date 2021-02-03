using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    class Benutzeraccount
    {
        public int AccountID { get; }
        public string Benutzername { get; set; }

        private string Passwort;
        public bool IstLeitung { get; set; }

        public Benutzeraccount(string Benutzername, string Passwort, bool IstLeitung)
        {
            this.Benutzername = Benutzername;
            this.Passwort = Passwort;
            this.IstLeitung = IstLeitung;
        }

        private void Login()
        {

        }
    }
}
