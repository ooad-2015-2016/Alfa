using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.DataBase.Models
{
    public class Menadzer : KorisnikSistema
    {
        public string nivoPristupa { get; set; }
        public double plata { get; set; }
        public Izvjestaj mjesecniIzvjestaj { get; set; }
    }
}
