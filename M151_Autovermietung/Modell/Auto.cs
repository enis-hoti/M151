using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M151_Autovermietung.Modell
{
    public class Auto
    {
        public int Id { get; set; }
        public string marke { get; set; }
        public string modell { get; set; }
        public int fk_preis { get; set; }
    }
}