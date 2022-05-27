using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class OrderItems : Entity
    {
        public int Order_Id { get; set; }

        public int Product_Id { get; set; }

        public int Quantity { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }


        public virtual OrderDetails OrderDetails { get; set; }

        public virtual Product Product { get; set; }

    }
}