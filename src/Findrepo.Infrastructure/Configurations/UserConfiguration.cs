using Findrepo.Domain.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Findrepo.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("User");

            builder.Property(user => user.Id)
               .HasColumnName("Id").IsRequired();

            builder.Property(user => user.Password)
               .HasColumnName("Password").IsRequired();

            builder.Property(user => user.Email)
               .HasColumnName("Email").IsRequired();

            builder.Property(user => user.Name)
               .HasColumnName("Name").IsRequired();
        }
    }
}
