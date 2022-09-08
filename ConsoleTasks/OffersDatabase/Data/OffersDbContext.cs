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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=.;Database=OffersDb;User Id=sa;Password=123456!!XX;");
    }
}
