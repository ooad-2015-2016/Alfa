using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PogrebnoDrustvo.OpremaBaza.Models
{
    class Oprema
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idOpreme { get; set; }  //Primary key
        public double cijena { get; set; }
        public string naziv { get; set; }
        public double visina { get; set; }
        public double sirina { get; set; }
    }
}
