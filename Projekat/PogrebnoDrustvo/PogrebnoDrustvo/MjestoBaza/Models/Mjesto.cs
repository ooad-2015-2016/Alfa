using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext_Tabela.MjestaBaza.Models
{
    class Mjesto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MjestoId { get; set; }//primary key u bazi
        public string adresa { get; set; }
        public string nazivLokacije { get; set; }
        public double cijena { get; set; }
    }
}
