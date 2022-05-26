using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class UserAddressMap : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.ToTable("UserAddress");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.User_id)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Address_line1)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Address_line2)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.City)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.PostalCode)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Country)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasOne(p => p.User)
                .WithMany(p => p.UserAddresses)
                .HasForeignKey(p => p.User_id);
        }
    }
}
