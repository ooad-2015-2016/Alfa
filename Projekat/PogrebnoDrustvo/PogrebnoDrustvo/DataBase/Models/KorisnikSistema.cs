using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class KorisnikSistema : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idKorisnika { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
