using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class DiscountMap : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.ToTable("Discounts");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(p => p.Discount_Percent)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Created_at)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}