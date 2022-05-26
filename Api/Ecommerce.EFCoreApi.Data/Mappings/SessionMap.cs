using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class SessionMap : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("Session");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.User_Id)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Total)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(x => x.Created_At)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.Modified_At)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithOne(x => x.Session)
                .HasForeignKey<Session>(x => x.User_Id)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
