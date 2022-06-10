using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Request
{
    public class UpdateInventoryRequest
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }

        public UpdateInventoryRequest(int quantity)
        {
            Quantity = quantity;
            Created_At = DateTime.Now;
            Updated_At = DateTime.Now;
        }

        public static ProductInventory ToEntity(UpdateInventoryRequest request)
        {
            return new ProductInventory
            {
                Id = request.Id,
                Quantity = request.Quantity,
                CreatedDate = request.Created_At,
                UpdatedDate = request.Updated_At
            };
        }
    }
}