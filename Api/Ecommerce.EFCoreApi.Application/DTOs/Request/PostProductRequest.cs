using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class PostProductRequest
    {

        public string Product_Sku { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


        public PostProductRequest(string product_Sku, int categoryId, string name, string description, decimal price)
        {
            Product_Sku = product_Sku;
            CategoryId = categoryId;
            Name = name;
            Description = description;
            Price = price;
        }


        public static Product ToEntity(PostProductRequest request)
        {
            return new Product
            {
                Product_Sku = request.Product_Sku,
                CategoryId = request.CategoryId,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price
            };
        }
    }
}