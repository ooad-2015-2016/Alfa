using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Windows.Storage;

namespace PogrebnoDrustvo.OpremaBaza.Models
{
    class OpremaDbContext : DbContext
    {
        public DbSet<Oprema> _oprema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Ooadbaze.db";

            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch(InvalidOperationException)
            {

            }
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
       /*protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
             //modelBuilder.Entity<Mjesto>().Property(p => p.Slika).HasColumnType("image");
         }*/
    }
}
