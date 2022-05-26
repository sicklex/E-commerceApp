using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public class ProductInventoryMap : IEntityTypeConfiguration<ProductInventory>
    {
        public void Configure(EntityTypeBuilder<ProductInventory> builder)
        {

            builder.ToTable("ProductInventories");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Quantity)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.CreatedDate)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.UpdatedDate)
                .HasColumnType("datetime")
                .IsRequired();


            builder.HasOne(p => p.Product)
                .WithOne(pi => pi.Inventory)
                .HasForeignKey<ProductInventory>(pi => pi.Id);
        }
    }
}