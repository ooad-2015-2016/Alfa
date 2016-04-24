using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbContext_Tabela.PreminuliBaza.Models
{
    public class Preminuli
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int barKodUmrlog { get; set; }
        public string imeUmrlog { get; set; }
        public string prezimeUmrlog { get; set; }
        public DateTime datumRodjenja { get; set; }
        public DateTime datumSmrti { get; set; }
        public string pogrebnaLokacija { get; set; }
    }
}
