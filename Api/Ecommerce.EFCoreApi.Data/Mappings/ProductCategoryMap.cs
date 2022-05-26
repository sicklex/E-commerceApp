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
    public class ProductCategoryMap : IEntityTypeConfiguration<ProductCategories>
    {
        public void Configure(EntityTypeBuilder<ProductCategories> builder)
        {
            builder.ToTable("ProductCategories");

            builder.HasOne(pc => pc.Product)
                .WithMany(p => p.Product_Categories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(pc => pc.Categories)
                .WithMany(c => c.Product_Categories)
                .HasForeignKey(pc => pc.CategoriesId);
        }
    }
}
