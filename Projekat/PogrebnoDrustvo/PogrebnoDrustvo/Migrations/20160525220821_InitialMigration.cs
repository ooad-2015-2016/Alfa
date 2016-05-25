using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace PogrebnoDrustvoMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Izvjestaj",
                columns: table => new
                {
                    idIzvjestaja = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    brojKorisnika = table.Column(type: "INTEGER", nullable: false),
                    brojUkopanih = table.Column(type: "INTEGER", nullable: false),
                    mjesecnaZarada = table.Column(type: "REAL", nullable: false),
                    mjesecniTroskovi = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaj", x => x.idIzvjestaja);
                });
            migration.CreateTable(
                name: "KorisnikSistema",
                columns: table => new
                {
                    idKorisnika = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    ime = table.Column(type: "TEXT", nullable: true),
                    password = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikSistema", x => x.idKorisnika);
                });
            migration.CreateTable(
                name: "Mjesto",
                columns: table => new
                {
                    idMjesta = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    cijena = table.Column(type: "REAL", nullable: false),
                    nazivLokacije = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mjesto", x => x.idMjesta);
                });
            migration.CreateTable(
                name: "Snimatelj",
                columns: table => new
                {
                    idSnimatelja = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    cijenaUsluge = table.Column(type: "REAL", nullable: false),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snimatelj", x => x.idSnimatelja);
                });
            migration.CreateTable(
                name: "Radnik",
                columns: table => new
                {
                    idRadnika = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    IzvjestajidIzvjestaja = table.Column(type: "INTEGER", nullable: true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    ime = table.Column(type: "TEXT", nullable: true),
                    plata = table.Column(type: "REAL", nullable: false),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    radnoVrijeme = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnik", x => x.idRadnika);
                    table.ForeignKey(
                        name: "FK_Radnik_Izvjestaj_IzvjestajidIzvjestaja",
                        columns: x => x.IzvjestajidIzvjestaja,
                        referencedTable: "Izvjestaj",
                        referencedColumn: "idIzvjestaja");
                });
            migration.CreateTable(
                name: "Vozac",
                columns: table => new
                {
                    idVozaca = table.Column(type: "INTEGER", nullable: false),
                      //  .Annotation("Sqlite:Autoincrement", true),
                    IzvjestajidIzvjestaja = table.Column(type: "INTEGER", nullable: true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojTelefona = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    godineIskustva = table.Column(type: "INTEGER", nullable: false),
                    ime = table.Column(type: "TEXT", nullable: true),
                    plata = table.Column(type: "REAL", nullable: false),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozac", x => x.idVozaca);
                    table.ForeignKey(
                        name: "FK_Vozac_Izvjestaj_IzvjestajidIzvjestaja",
                        columns: x => x.IzvjestajidIzvjestaja,
                        referencedTable: "Izvjestaj",
                        referencedColumn: "idIzvjestaja");
                });
            migration.CreateTable(
                name: "Preminuli",
                columns: table => new
                {
                    barKodPreminulog = table.Column(type: "INTEGER", nullable: false),
                      //  .Annotation("Sqlite:Autoincrement", true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    datumSmrti = table.Column(type: "TEXT", nullable: false),
                    ime = table.Column(type: "TEXT", nullable: true),
                    pogrebnaLokacijaidMjesta = table.Column(type: "INTEGER", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preminuli", x => x.barKodPreminulog);
                    table.ForeignKey(
                        name: "FK_Preminuli_Mjesto_pogrebnaLokacijaidMjesta",
                        columns: x => x.pogrebnaLokacijaidMjesta,
                        referencedTable: "Mjesto",
                        referencedColumn: "idMjesta");
                });
            migration.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    idZahtjeva = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    IzvjestajidIzvjestaja = table.Column(type: "INTEGER", nullable: true),
                    angazovanjeSnimatelja = table.Column(type: "INTEGER", nullable: false),
                    izradaSmrtovnice = table.Column(type: "INTEGER", nullable: false),
                    mjestoidMjesta = table.Column(type: "INTEGER", nullable: true),
                    placeno = table.Column(type: "INTEGER", nullable: false),
                    potvrdaZahtjeva = table.Column(type: "INTEGER", nullable: false),
                    preminulibarKodPreminulog = table.Column(type: "INTEGER", nullable: true),
                    transportOzaloscenih = table.Column(type: "INTEGER", nullable: false),
                    troskoviPogreba = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.idZahtjeva);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Izvjestaj_IzvjestajidIzvjestaja",
                        columns: x => x.IzvjestajidIzvjestaja,
                        referencedTable: "Izvjestaj",
                        referencedColumn: "idIzvjestaja");
                    table.ForeignKey(
                        name: "FK_Zahtjev_Mjesto_mjestoidMjesta",
                        columns: x => x.mjestoidMjesta,
                        referencedTable: "Mjesto",
                        referencedColumn: "idMjesta");
                    table.ForeignKey(
                        name: "FK_Zahtjev_Preminuli_preminulibarKodPreminulog",
                        columns: x => x.preminulibarKodPreminulog,
                        referencedTable: "Preminuli",
                        referencedColumn: "barKodPreminulog");
                });
            migration.CreateTable(
                name: "Oprema",
                columns: table => new
                {
                    idOpreme = table.Column(type: "INTEGER", nullable: false),
                      //  .Annotation("Sqlite:Autoincrement", true),
                    ZahtjevidZahtjeva = table.Column(type: "INTEGER", nullable: true),
                    cijena = table.Column(type: "REAL", nullable: false),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    sirina = table.Column(type: "REAL", nullable: false),
                    visina = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oprema", x => x.idOpreme);
                    table.ForeignKey(
                        name: "FK_Oprema_Zahtjev_ZahtjevidZahtjeva",
                        columns: x => x.ZahtjevidZahtjeva,
                        referencedTable: "Zahtjev",
                        referencedColumn: "idZahtjeva");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("KorisnikSistema");
            migration.DropTable("Oprema");
            migration.DropTable("Radnik");
            migration.DropTable("Snimatelj");
            migration.DropTable("Vozac");
            migration.DropTable("Zahtjev");
            migration.DropTable("Izvjestaj");
            migration.DropTable("Preminuli");
            migration.DropTable("Mjesto");
        }
    }
}
