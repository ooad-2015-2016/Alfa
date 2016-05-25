using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using PogrebnoDrustvo.Database.Models;

namespace PogrebnoDrustvoMigrations
{
    [ContextType(typeof(PogrebnoDrustrvoDbContext))]
    partial class PogrebnoDrustrvoDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("PogrebnoDrustvo.Database.Models.Izvjestaj", b =>
                {
                    b.Property<int>("idIzvjestaja")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("brojKorisnika");

                    b.Property<int>("brojUkopanih");

                    b.Property<double>("mjesecnaZarada");

                    b.Property<double>("mjesecniTroskovi");

                    b.Key("idIzvjestaja");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.KorisnikSistema", b =>
                {
                    b.Property<int>("idKorisnika")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<string>("brojTelefona");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("ime");

                    b.Property<string>("password");

                    b.Property<string>("prezime");

                    b.Property<string>("username");

                    b.Key("idKorisnika");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Mjesto", b =>
                {
                    b.Property<int>("idMjesta")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<double>("cijena");

                    b.Property<string>("nazivLokacije");

                    b.Key("idMjesta");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Oprema", b =>
                {
                    b.Property<int>("idOpreme")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ZahtjevidZahtjeva");

                    b.Property<double>("cijena");

                    b.Property<string>("naziv");

                    b.Property<double>("sirina");

                    b.Property<double>("visina");

                    b.Key("idOpreme");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Preminuli", b =>
                {
                    b.Property<int>("barKodPreminulog")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<DateTime>("datumSmrti");

                    b.Property<string>("ime");

                    b.Property<int?>("pogrebnaLokacijaidMjesta");

                    b.Property<string>("prezime");

                    b.Key("barKodPreminulog");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Radnik", b =>
                {
                    b.Property<int>("idRadnika")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("IzvjestajidIzvjestaja");

                    b.Property<string>("adresa");

                    b.Property<string>("brojTelefona");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("ime");

                    b.Property<double>("plata");

                    b.Property<string>("prezime");

                    b.Property<DateTime>("radnoVrijeme");

                    b.Key("idRadnika");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Snimatelj", b =>
                {
                    b.Property<int>("idSnimatelja")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<string>("brojTelefona");

                    b.Property<double>("cijenaUsluge");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("ime");

                    b.Property<string>("prezime");

                    b.Key("idSnimatelja");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Vozac", b =>
                {
                    b.Property<int>("idVozaca")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("IzvjestajidIzvjestaja");

                    b.Property<string>("adresa");

                    b.Property<string>("brojTelefona");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<int>("godineIskustva");

                    b.Property<string>("ime");

                    b.Property<double>("plata");

                    b.Property<string>("prezime");

                    b.Key("idVozaca");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Zahtjev", b =>
                {
                    b.Property<int>("idZahtjeva")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("IzvjestajidIzvjestaja");

                    b.Property<bool>("angazovanjeSnimatelja");

                    b.Property<bool>("izradaSmrtovnice");

                    b.Property<int?>("mjestoidMjesta");

                    b.Property<bool>("placeno");

                    b.Property<bool>("potvrdaZahtjeva");

                    b.Property<int?>("preminulibarKodPreminulog");

                    b.Property<bool>("transportOzaloscenih");

                    b.Property<double>("troskoviPogreba");

                    b.Key("idZahtjeva");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Oprema", b =>
                {
                    b.Reference("PogrebnoDrustvo.Database.Models.Zahtjev")
                        .InverseCollection()
                        .ForeignKey("ZahtjevidZahtjeva");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Preminuli", b =>
                {
                    b.Reference("PogrebnoDrustvo.Database.Models.Mjesto")
                        .InverseCollection()
                        .ForeignKey("pogrebnaLokacijaidMjesta");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Radnik", b =>
                {
                    b.Reference("PogrebnoDrustvo.Database.Models.Izvjestaj")
                        .InverseCollection()
                        .ForeignKey("IzvjestajidIzvjestaja");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Vozac", b =>
                {
                    b.Reference("PogrebnoDrustvo.Database.Models.Izvjestaj")
                        .InverseCollection()
                        .ForeignKey("IzvjestajidIzvjestaja");
                });

            builder.Entity("PogrebnoDrustvo.Database.Models.Zahtjev", b =>
                {
                    b.Reference("PogrebnoDrustvo.Database.Models.Izvjestaj")
                        .InverseCollection()
                        .ForeignKey("IzvjestajidIzvjestaja");

                    b.Reference("PogrebnoDrustvo.Database.Models.Mjesto")
                        .InverseCollection()
                        .ForeignKey("mjestoidMjesta");

                    b.Reference("PogrebnoDrustvo.Database.Models.Preminuli")
                        .InverseCollection()
                        .ForeignKey("preminulibarKodPreminulog");
                });
        }
    }
}
