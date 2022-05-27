using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class PaymentDetailsMap : IEntityTypeConfiguration<PaymentDetails>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PaymentDetails> builder)
        {

            builder.ToTable("Payment Details");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Order_id)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Amount)
                .HasColumnType("int")
                .IsRequired();


            builder.Property(x => x.Provider)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Created_At)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.Modified_At)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}