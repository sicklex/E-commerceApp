using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class OrderDetailsMap : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderDetails> builder)
        {

            builder.ToTable("Order Details");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Total)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Created_At)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.Modified_At)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithOne(x => x.OrderDetails)
                .HasForeignKey<OrderDetails>(x => x.UserId);

            builder.HasOne(x => x.PaymentDetails)
                .WithOne(x => x.OrderDetails)
                .HasForeignKey<OrderDetails>(x => x.Payment_Id);

        }
    }
}