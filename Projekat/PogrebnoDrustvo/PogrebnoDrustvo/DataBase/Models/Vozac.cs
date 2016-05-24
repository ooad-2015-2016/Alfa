using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.DataBase.Models
{
    public class Vozac : Osoba
    {
        public double plata { get; set; }
        public int godineIskustva { get; set; }
    }
}
