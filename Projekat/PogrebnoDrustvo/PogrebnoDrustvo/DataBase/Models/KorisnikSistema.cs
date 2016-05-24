using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.DataBase.Models
{
    public class KorisnikSistema : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //tek nam ovde treba primarny kljuc
        public int idKorisnika { get; set; }
        public string username { get; set; }
        public string passwork { get; set; }
    }
}
