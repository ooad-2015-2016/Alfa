using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using Windows.Storage;
using System.IO;

namespace PogrebnoDrustvo.Database.Models
{
    public class PogrebnoDrustrvoDbContext : DbContext
    {
        public DbSet<KorisnikSistema> korisniciSistema { get; set; }
        public DbSet<Mjesto> mjesta { get; set; }
        public DbSet<Preminuli> preminuli { get; set; }
        public DbSet<Izvjestaj> izvjestaji { get; set; }
        public DbSet<Zahtjev> zahtjevi { get; set; }
        public DbSet<Oprema> oprema { get; set; }
        public DbSet<Radnik> radnici { get; set; }
        public DbSet<Vozac> vozaci { get; set; }
        public DbSet<Snimatelj> snimatelji { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "PogrebnoDrustvoBaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException)
            {
                optionsBuilder.UseSqlite($"Data source = {databaseFilePath}");
            }


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Ovo dodat dole za svaku klasu ako hocemo da se podrzi rad ako imamo atiribute sa slikom ,tj atribute tipa byte
            //modelBuilder.Entity<KLASA>().Property(p => p.Slika).HasColumnType("image");
        }

    }
}
