using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class InventoryRequest
    {
        public int Quantity { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Updated_At { get; set; }

        public InventoryRequest(int quantity, DateTime created_At, DateTime updated_At)
        {
            Quantity = quantity;
            Created_At = DateTime.Now;
            Updated_At = DateTime.Now;
        }

        public static ProductInventory ToEntity(InventoryRequest request)
        {
            return new ProductInventory
            {
                Quantity = request.Quantity,

                CreatedDate = request.Created_At,

                UpdatedDate = request.Updated_At
            };
        }
    }
}