using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.DataBase.Models
{
    public class Korisnik : KorisnikSistema
    {
        public DateTime datumKreiranjaNaloga { get; set; }
        public List<Zahtjev> zahtjevi { get; set; }
        public string nivoPristupa {get; set;}

    }
}
