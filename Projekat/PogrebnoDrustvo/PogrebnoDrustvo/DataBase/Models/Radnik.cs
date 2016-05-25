using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class Radnik : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idRadnika { get; set; }
        public double plata { get; set; }
        public DateTime radnoVrijeme { get; set; }
    }
}
