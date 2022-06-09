
using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductSku { get; set; }
        public int CategoryId { get; set; }
        public int InventoryId { get; set; }
        public decimal Price { get; set; }
        public int DiscountId { get; set; }
        public DateTime Created_At { get; set; }


        public AddProductRequest(string name, string description, string productSku, int categoryId, int inventoryId, decimal price, int discountId)
        {
            Name = name;
            Description = description;
            ProductSku = productSku;
            CategoryId = categoryId;
            InventoryId = inventoryId;
            Price = price;
            DiscountId = discountId;
        }


        public static Product ToEntity(AddProductRequest request)
        {
            return new Product
            (
                request.Name,
                request.Description,
                request.ProductSku,
                request.CategoryId,
                request.InventoryId,
                request.Price,
                request.DiscountId
            );
        }








    }

}