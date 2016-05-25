using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class Mjesto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idMjesta { get; set; }//primary key, a za ostala polja je jasno
        public string adresa { get; set; }
        public string nazivLokacije { get; set; }
        public double cijena { get; set; }
    }
}
