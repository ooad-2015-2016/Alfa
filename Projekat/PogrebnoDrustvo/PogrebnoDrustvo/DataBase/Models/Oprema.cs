using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class Oprema
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idOpreme { get; set; }  //Primary key
        public double cijena { get; set; }
        public string naziv { get; set; }
        public double visina { get; set; }
        public double sirina { get; set; }
        public string slikaOpreme { get; set; }

        
    }
    

}
