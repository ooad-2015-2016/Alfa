using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class Zahtjev
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idZahtjeva { get; set; }
        public Mjesto mjesto { get; set; }
        public Preminuli preminuli { get; set; }
        public List<Oprema> listaOpreme { get; set; }
        public double troskoviPogreba { get; set; }
        public bool izradaSmrtovnice { get; set; }
        public bool transportOzaloscenih { get; set; }
        public bool angazovanjeSnimatelja { get; set; }
        public bool potvrdaZahtjeva { get; set; }
        public bool placeno { get; set; }
    }
}
