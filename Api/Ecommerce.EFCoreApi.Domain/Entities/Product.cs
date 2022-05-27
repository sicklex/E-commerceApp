using DevInHouse.EFCoreApi.Core.Entities;


namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Product_Sku { get; set; }
        public int CategoryId { get; set; }
        public int InventoryId { get; set; }
        public decimal Price { get; set; }
        public int Discount_id { get; set; }

        public virtual ProductInventory Inventory { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual OrderItems OrderItems { get; set; }

    }
}
