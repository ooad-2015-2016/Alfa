using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using DbContext_Tabela.MjestaBaza.Models;

namespace PogrebnoDrustvoMigrations
{
    [ContextType(typeof(MjestoDbContext))]
    partial class MjestoDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("DbContext_Tabela.MjestaBaza.Models.Mjesto", b =>
                {
                    b.Property<int>("MjestoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<double>("cijena");

                    b.Property<string>("nazivLokacije");

                    b.Key("MjestoId");
                });
        }
    }
}
