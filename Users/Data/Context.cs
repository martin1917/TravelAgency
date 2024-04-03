using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace Users.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<TourAgent> TourAgents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasOne(x => x.Client)
                .WithOne(c => c.Account)
                .HasForeignKey<Client>(c => c.AccountId);

            modelBuilder.Entity<Account>()
                .HasOne(x => x.TourAgent)
                .WithOne(t => t.Account)
                .HasForeignKey<TourAgent>(t => t.AccountId);
        }
    }
}
