
using Ecommerce.EFCoreApi.Domain.Entities.Shared;
namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class ProductInventory : Entity
    {

        public int Id { get; set; }
        public int Quantity { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Product Product { get; set; }

        /* 
                public ProductInventory(int id, int quantity, DateTime createdDate, DateTime updatedDate)
                {
                    Quantity = quantity;
                    CreatedDate = createdDate;
                    UpdatedDate = updatedDate;
                }

                public ProductInventory()
                {
                }

                public ProductInventory(int id, int quantity, DateTime updatedDate)
                {
                    Id = id;
                    Quantity = quantity;
                    CreatedDate = CreatedDate;
                    UpdatedDate = updatedDate;
                }
         */

    }
}
