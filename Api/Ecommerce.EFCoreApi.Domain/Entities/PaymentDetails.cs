using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class PaymentDetails : Entity
    {
        public int Order_id { get; set; }

        public int Amount { get; set; }

        public string Provider { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }
    }
}