using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PogrebnoDrustvo.Database.Models;
namespace PogrebnoDrustvo
{
    public sealed partial class Cjenovnik
    {
        private List<Oprema> oprema;

        public Cjenovnik()
        {

            oprema = Cjenovnik.dajOpremu();
            this.InitializeComponent();
        }
        

        public static List<Oprema> dajOpremu()
        {
            var listaopreme = new List<Oprema>();
            listaopreme.Add(new Oprema { idOpreme = 1, cijena = 300, naziv = "Tabuti", visina = 200, sirina = 50, slikaOpreme = "/Assets/tabut.jpg" });
            listaopreme.Add(new Oprema { idOpreme = 2, cijena = 75, naziv = "Ćefini", visina = 200, sirina = 50, slikaOpreme = "/Assets/cefini.jpg " });
            listaopreme.Add(new Oprema { idOpreme = 3, cijena = 199, naziv = "Kombi vozilo", visina = 200, sirina = 50, slikaOpreme = "/Assets/vozilokombi.jpg" });
            listaopreme.Add(new Oprema { idOpreme = 4, cijena = 450, naziv = "Stojadin", visina = 200, sirina = 50, slikaOpreme = "/Assets/stojadin.jpg" });
            listaopreme.Add(new Oprema { idOpreme = 5, cijena = 150, naziv = "Gasuljenje", visina = 200, sirina = 50, slikaOpreme = "/Assets/kupanje.jpg" });
            listaopreme.Add(new Oprema { idOpreme = 6, cijena = 200, naziv = "Udobni naslonjači", visina = 200, sirina = 50, slikaOpreme = "/Assets/nasloni.jpg" });
            listaopreme.Add(new Oprema { idOpreme = 7, cijena = 10, naziv = "Prijevoz ožalošćenih", visina = 200, sirina = 50, slikaOpreme = "/Assets/prijevoz.jpg" });
            listaopreme.Add(new Oprema { idOpreme = 8, cijena = 5, naziv = "Posmrtnice", visina = 200, sirina = 50, slikaOpreme = "/Assets/posmrtnice.jpg" });
            listaopreme.Add(new Oprema { idOpreme = 9, cijena = 2500, naziv = "Stećci po narudžbi", visina = 200, sirina = 50, slikaOpreme = "/Assets/stecak.jpg" });
            return listaopreme;
        }


    }
}
