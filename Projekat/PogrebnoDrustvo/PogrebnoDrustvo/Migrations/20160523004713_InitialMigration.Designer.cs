using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using DbContext_Tabela.ZahtjevBaza.Models;

namespace PogrebnoDrustvoMigrations
{
    [ContextType(typeof(ZahtjevDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160523004713_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("DbContext_Tabela.ZahtjevBaza.Models.Zahtjev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("angazovanjeSnimatelja");

                    b.Property<bool>("izradaSmrtovnice");

                    b.Property<string>("mjesto");

                    b.Property<bool>("placeno");

                    b.Property<bool>("potvrdaZahtjeva");

                    b.Property<string>("preminuli");

                    b.Property<bool>("transportOzaloscenih");

                    b.Property<double>("troskoviPogreba");

                    b.Key("Id");
                });
        }
    }
}
