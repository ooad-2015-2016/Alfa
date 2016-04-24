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
                name: "Mjesto",
                columns: table => new
                {
                    MjestoId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    cijena = table.Column(type: "REAL", nullable: false),
                    nazivLokacije = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mjesto", x => x.MjestoId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Mjesto");
        }
    }
}
