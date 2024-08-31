using Findrepo.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Findrepo.Infrastructure.Context
{
    public class FindrepoContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public FindrepoContext(DbContextOptions<FindrepoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}