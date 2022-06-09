using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Product_sku { get; set; }

        public int CategoryId { get; set; }

        public int InventoryId { get; set; }

        public int DiscountId { get; set; }

        public DateTime Created_At { get; set; }


        public UpdateProductRequest(string name, string description, decimal price, string product_sku, int categoryId, int inventoryId, int discountId)
        {
            Name = name;
            Description = description;
            Price = price;
            Product_sku = product_sku;
            CategoryId = categoryId;
            InventoryId = inventoryId;
            DiscountId = discountId;
            Created_At = DateTime.Now;
        }



        public static Product ToEntity(UpdateProductRequest request)
        {
            return new Product
            (
                request.Id,
                request.Name,
                request.Description,
                request.Product_sku,
                request.CategoryId,
                request.InventoryId,
                request.Price,
                request.DiscountId
            );
        }

    }

}


