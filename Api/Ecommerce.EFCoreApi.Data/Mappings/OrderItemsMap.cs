using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class OrderItemsMap : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderItems> builder)
        {
            builder.ToTable("Order_Items");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Quantity)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Created_At)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.Modified_At)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(p => p.OrderDetails)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(p => p.Order_Id);

            builder.HasOne(p => p.Product)
                .WithOne(p => p.OrderItems)
                .HasForeignKey<OrderItems>(p => p.Product_Id);


        }
    }
}