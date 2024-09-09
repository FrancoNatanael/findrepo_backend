using Findrepo.Domain.Entities.User;
using Findrepo.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Findrepo.Infrastructure.Context
{
    public class FindrepoContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public FindrepoContext(DbContextOptions<FindrepoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source=.\\SQLExpress;Database=Findrepo;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}