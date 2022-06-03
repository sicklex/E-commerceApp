
using Ecommerce.EFCoreApi.Domain.Entities.Shared;
namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class ProductInventory : Entity
    {

        public int Quantity { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Product Product { get; set; }

    }
}
