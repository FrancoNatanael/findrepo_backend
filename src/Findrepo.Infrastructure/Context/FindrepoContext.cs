using Findrepo.Domain.Entities.User;
using Findrepo.Infrastructure.Repositories;
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
                    .UseSqlServer("Data Source=;Initial Catalog=name_db;User ID=user;Password=password");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEFRepository());
        }
    }
}