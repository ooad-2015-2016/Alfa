using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext_Tabela.MjestaBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(MjestoDbContext context)
        {
            if (!context.mjesta.Any())
            {
                context.mjesta.AddRange(
                new Mjesto()
                {
                    adresa = "Zmaja od Bosne",
                    nazivLokacije = "Sarajevo",
                    cijena = 100,
                }
                );
                context.SaveChanges();
            }
        }
    }
}
