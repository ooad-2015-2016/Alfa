using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.DataBase.Models
{
    public class Radnik : Osoba
    {
        //Ne treba generisanje kljuca jer bazna klasa ima to ?Provjerit!
        public double plata { get; set; }
        public DateTime radnoVrijeme { get; set; }

    }
}
