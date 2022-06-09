using Ecommerce.EFCoreApi.Domain.Entities;

namespace Ecommerce.EFCoreApi.Application.DTOs.Response
{
    public class InventoryResponse
    {
        public int Quantity { get; set; }

        public InventoryResponse(int quantity)
        {
            Quantity = quantity;
        }


        public static InventoryResponse ToDTO(ProductInventory inventory)
        {
            return new InventoryResponse(inventory.Quantity);
        }
    }
}