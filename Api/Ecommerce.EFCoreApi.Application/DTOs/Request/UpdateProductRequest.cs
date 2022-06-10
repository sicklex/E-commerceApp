using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ProductSku { get; set; }

        public int CategoryId { get; set; }

        public int InventoryId { get; set; }

        public int DiscountId { get; set; }

        public DateTime Created_At { get; set; }


        public UpdateProductRequest(string name, string description, decimal price, string productSku, int categoryId, int inventoryId, int discountId, DateTime created_At)
        {
            Name = name;
            Description = description;
            Price = price;
            ProductSku = productSku;
            CategoryId = categoryId;
            InventoryId = inventoryId;
            DiscountId = discountId;
            Created_At = DateTime.Now;
        }

        public static Product ToEntity(UpdateProductRequest request)
        {
            return new Product
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Product_Sku = request.ProductSku,
                CategoryId = request.CategoryId,
                InventoryId = request.InventoryId,
                DiscountId = request.DiscountId,
                Created_At = request.Created_At
            };
        }
    }
}






