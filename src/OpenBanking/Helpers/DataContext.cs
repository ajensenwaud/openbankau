using Microsoft.EntityFrameworkCore;
using OpenBanking.Entities;
using OpenBanking.Models;

namespace OpenBanking.Helpers
{
    public class DataContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlite("Data Source=blogging.db");
            optionsBuilder.UseNpgsql(Startup.ConnectionString);
        }

        // public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }
    }
}
