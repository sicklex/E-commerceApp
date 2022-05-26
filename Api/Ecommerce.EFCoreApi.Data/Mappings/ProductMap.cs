using Ecommerce.EFCoreApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.EFCoreApi.Data.Mappings
{
    public  class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure (EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.ImageURL)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(p => p.Quantities)
                .HasColumnType("int")
                .IsRequired();


            builder.Property(p => p.Product_Sku)
                .HasColumnType("int")
                .IsRequired();

        }
    }
}