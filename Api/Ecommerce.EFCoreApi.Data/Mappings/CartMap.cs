using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class CartMap : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Session)
                .WithMany(p => p.Carts)
                .HasForeignKey(p => p.Session_Id);

            builder.HasOne(p => p.Product)
                .WithOne(p => p.Cart)
                .HasForeignKey<Cart>(p => p.Product_id);

            builder.Property(p => p.Quantity)
                .HasColumnType("int");


            builder.Property(p => p.Created_at)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.Modified_at)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}