using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class Preminuli
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int barKodPreminulog { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public DateTime datumSmrti { get; set; }
        public Mjesto pogrebnaLokacija { get; set; }
    }
}
