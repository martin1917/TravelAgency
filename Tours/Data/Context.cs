using Microsoft.EntityFrameworkCore;
using Tours.Models;

namespace Tours.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Tour> Tours { get; set; }

        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().Property(x => x.PricePurchase).HasPrecision(8, 2);
            modelBuilder.Entity<Tour>().Property(x => x.PriceSale).HasPrecision(8, 2);
            base.OnModelCreating(modelBuilder);
        }
    }
}
