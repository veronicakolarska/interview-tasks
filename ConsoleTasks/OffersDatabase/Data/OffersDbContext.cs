using Microsoft.EntityFrameworkCore;
using OffersDatabase.Models;

namespace OffersDatabase.Data
{
    public class OffersDbContext : DbContext
    {
        public DbSet<Offer> Offers { get; set; }

        public OffersDbContext()
        {
        }

        // TODO: This should be moved to a config file or an env variable and not be commited to git.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=.;Database=OffersDb;User Id=sa;Password=123456!!XX;");
    }
}
