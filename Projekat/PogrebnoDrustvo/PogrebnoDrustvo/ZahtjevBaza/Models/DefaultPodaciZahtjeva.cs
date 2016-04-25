using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext_Tabela.ZahtjevBaza.Models
{
    class DefaultPodaciZahtjeva
    {
        public static void Initialize(ZahtjevDbContext context)
        {
            if (!context.zahtjevi.Any())
            {
                context.zahtjevi.AddRange(
                new Zahtjev()
                {
                    troskoviPogreba = 100,
                    listaOpreme = new List<string> {"lopata","tabut", "ćefin"},
                    mjesto = "Bare",
                    angazovanjeSnimatelja = true,
                    transportOzaloscenih = true,
                    placeno = false,
                    potvrdaZahtjeva = true,
                    izradaSmrtovnice = false
                });
                context.SaveChanges();
            }
        }
    }
}
