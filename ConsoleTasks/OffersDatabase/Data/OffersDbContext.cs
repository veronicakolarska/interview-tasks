using Microsoft.EntityFrameworkCore;
using OffersDatabase.Models;

namespace OffersDatabase.Data
{
    public class OffersDbContext : DbContext
    {
        public DbSet<Offer> Offers { get; set; }

        public string DbPath { get; }

        public OffersDbContext()
        {
            var folder = Environment.SpecialFolder.DesktopDirectory;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "offers.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
