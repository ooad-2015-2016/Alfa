using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbContext_Tabela.ZahtjevBaza.Models
{
    public class Zahtjev
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  idZahtjeva{ get; set; }
        public string mjesto { get; set; }  // treba izmijeniti da bude tip Mjesto a ne string
        public string preminuli { get; set; } // također
        public List<string> listaOpreme { get; set; } // list<Oprema>
        public double troskoviPogreba{ get; set; }
        public bool izradaSmrtovnice { get; set; }
        public bool transportOzaloscenih { get; set; }
        public bool angazovanjeSnimatelja { get; set; }
        public bool potvrdaZahtjeva { get; set; }
        public bool placeno { get; set; }
    }

}