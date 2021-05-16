using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M151_Autovermietung.Modell
{
    public class Miete
    {
        public int Id { get; set; }
        public int fk_auto { get; set; }
        public int fk_mieter { get; set; }
    }
}