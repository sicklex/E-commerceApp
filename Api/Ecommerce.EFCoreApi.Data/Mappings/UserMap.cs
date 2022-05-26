using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserName)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Password)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.FirstName)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Telephone)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Created_at)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}