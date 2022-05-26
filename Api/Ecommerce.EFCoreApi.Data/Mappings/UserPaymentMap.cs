using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class UserPaymentMap : IEntityTypeConfiguration<UserPayment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserPayment> builder)
        {
            builder.ToTable("UserPayment");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.User_id)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.payment_type)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Account_no)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Expiry)
                .HasColumnType("date")
                .IsRequired();

            builder.HasOne(p => p.User)
                .WithMany(p => p.UserPayments)
                .HasForeignKey(p => p.User_id);

        }
    }
}