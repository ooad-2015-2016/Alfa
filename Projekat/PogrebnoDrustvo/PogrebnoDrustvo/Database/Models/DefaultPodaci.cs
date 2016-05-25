using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.Database.Models
{
    public class DefaultPodaci
    {
        public static void Initialize(PogrebnoDrustrvoDbContext context)
        {

            if (!context.izvjestaji.Any())
            {
                context.izvjestaji.AddRange(
                    new Izvjestaj()
                    {
                        brojUkopanih = 0,
                        brojKorisnika = 0,
                        mjesecnaZarada = 0,
                        mjesecniTroskovi = 0
                        
                    }
                    
                 );
                context.SaveChanges();
            }
            if (!context.korisniciSistema.Any())
            {
                context.korisniciSistema.AddRange(
                    new KorisnikSistema()
                    {
                        username = "korisnik",
                        password = "password"
                    }

                 );
                context.SaveChanges();
            }

            if (!context.mjesta.Any())
            {
                context.mjesta.AddRange(
                    new Mjesto()
                    {
                        adresa = "Bare",
                        nazivLokacije = "Groblje Bare",
                        cijena = 0
                    }

                 );
                context.SaveChanges();
            }

            if (!context.oprema.Any())
            {
                context.oprema.AddRange(
                    new Oprema()
                    {
                        cijena = 0,
                        naziv = "",
                        visina = 0,
                        sirina = 0
                    }

                 );
                context.SaveChanges();
            }

            if (!context.preminuli.Any())
            {
                context.preminuli.AddRange(
                    new Preminuli()
                    {
                        ime = "ime preminulog",
                        prezime = "prezime preminulog",
                        datumRodjenja = new DateTime(10,10,1950),
                        datumSmrti = DateTime.Today
                    }

                 );
                context.SaveChanges();
            }

            if (!context.radnici.Any())
            {
                context.radnici.AddRange(
                    new Radnik()
                    {
                        plata = 0,
                        radnoVrijeme = DateTime.Today
                    }

                 );
                context.SaveChanges();
            }

            if (!context.snimatelji.Any())
            {
                context.snimatelji.AddRange(
                    new Snimatelj()
                    {
                        cijenaUsluge = 0
                    }

                 );
                context.SaveChanges();
            }

            if (!context.vozaci.Any())
            {
                context.vozaci.AddRange(
                    new Vozac()
                    {
                        plata = 0,
                        godineIskustva = 0
                    }

                 );
                context.SaveChanges();
            }

            if (!context.zahtjevi.Any())
            {
                context.zahtjevi.AddRange(
                    new Zahtjev()
                    {
                        troskoviPogreba = 0,
                        transportOzaloscenih = false,
                        angazovanjeSnimatelja = false,
                        izradaSmrtovnice = false,
                        potvrdaZahtjeva = false,
                        placeno = false
                    }

                 );
                context.SaveChanges();
            }




        }
    }
}
