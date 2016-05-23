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
                name: "Zahtjev",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    angazovanjeSnimatelja = table.Column(type: "INTEGER", nullable: false),
                    izradaSmrtovnice = table.Column(type: "INTEGER", nullable: false),
                    mjesto = table.Column(type: "TEXT", nullable: true),
                    placeno = table.Column(type: "INTEGER", nullable: false),
                    potvrdaZahtjeva = table.Column(type: "INTEGER", nullable: false),
                    preminuli = table.Column(type: "TEXT", nullable: true),
                    transportOzaloscenih = table.Column(type: "INTEGER", nullable: false),
                    troskoviPogreba = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.Id);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Zahtjev");
        }
    }
}
