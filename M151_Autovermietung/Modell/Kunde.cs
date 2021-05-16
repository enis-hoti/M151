using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M151_Autovermietung.Modell
{
    public class Kunde
    {
        public int Id { get; set; }
        public string benutzername { get; set; }
        public string passwort { get; set; }
        public string vorname { get; set; }
        public string nachname { get; set; }
        public string benutzergruppe { get; set; }
    }
}