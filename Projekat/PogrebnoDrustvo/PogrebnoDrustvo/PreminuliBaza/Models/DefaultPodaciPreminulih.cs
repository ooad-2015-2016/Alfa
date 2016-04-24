using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext_Tabela.PreminuliBaza.Models
{
    class DefaultPodaciPreminulih
    {
        public static void Initialize(PreminuliDbContext context)
        {
            if (!context.preminuli.Any())
            {
                context.preminuli.AddRange(
                new Preminuli()
                {
                    barKodUmrlog = 1,
                    imeUmrlog = "Paja",
                    prezimeUmrlog = "Patak",
                    datumRodjenja = DateTime.Today,
                    datumSmrti = DateTime.Today,
                    pogrebnaLokacija = "Groblje LAV"
                });
                context.SaveChanges();
            }
        }
    }
}
