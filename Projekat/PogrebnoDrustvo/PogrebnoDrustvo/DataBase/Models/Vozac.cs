using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class Vozac : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idVozaca { get; set; }
        public double plata { get; set; }
        public int godineIskustva { get; set; }
    }
}
