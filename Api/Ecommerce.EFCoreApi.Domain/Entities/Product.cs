
using Ecommerce.EFCoreApi.Domain.Entities.Shared;
namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Product : Entity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string Product_Sku { get; set; }
        public int CategoryId { get; set; }
        public int InventoryId { get; set; }
        public decimal Price { get; set; }
        public int DiscountId { get; set; }
        public DateTime Created_At { get; set; }


        public virtual ProductInventory Inventory { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual OrderItems OrderItems { get; set; }

        public Product(string name, string description, string productSku, int categoryId, int inventoryId, decimal price, int discountId)
        {
            Name = name;
            Description = description;
            Product_Sku = productSku;
            CategoryId = categoryId;
            InventoryId = inventoryId;
            Price = price;
            DiscountId = discountId;
        }

        public Product()
        {

        }

    }

}
