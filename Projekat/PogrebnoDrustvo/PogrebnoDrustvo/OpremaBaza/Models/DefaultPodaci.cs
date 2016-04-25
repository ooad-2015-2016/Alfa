using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.OpremaBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(OpremaDbContext context)
        {
            if (!context._oprema.Any())
            {
                context._oprema.AddRange(
                new Oprema()
                {
                    cijena = 50,
                    naziv = "Kovceg",
                    visina =175,
                    sirina = 80,
                }
                );
                context.SaveChanges();
            }
        }
    }
}
