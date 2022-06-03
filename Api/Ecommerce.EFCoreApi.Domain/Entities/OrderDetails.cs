using Ecommerce.EFCoreApi.Domain.Entities.Shared;
namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class OrderDetails : Entity
    {
        public int UserId { get; set; }

        public int Total { get; set; }

        public int Payment_Id { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }


        public virtual User User { get; set; }

        public virtual PaymentDetails PaymentDetails { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}