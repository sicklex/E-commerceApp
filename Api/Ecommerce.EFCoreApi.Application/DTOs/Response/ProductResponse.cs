using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Response
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Product_Sku { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Created_At { get; set; }

        public CategoryResponse CategoryReponse { get; set; }


        public ProductResponse(int id, string product_Sku, int categoryId, string name,
         string description, decimal price, DateTime created_At, CategoryResponse categoryReponse)
        {
            Id = id;
            Product_Sku = product_Sku;
            CategoryId = categoryId;
            Name = name;
            Description = description;
            Price = price;
            Created_At = created_At;
            CategoryReponse = categoryReponse;
        }

        public static ProductResponse ToDTO(Product product)
        {
            return new ProductResponse
            (
                product.Id,
                product.Product_Sku,
                product.CategoryId,
                product.Name,
                product.Description,
                product.Price,
                product.Created_At,
                new CategoryResponse(product.CategoryId, product.Categories.Name)
            );
        }
    }
}