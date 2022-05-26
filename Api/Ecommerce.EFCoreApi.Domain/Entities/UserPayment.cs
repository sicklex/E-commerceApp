using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class UserPayment : Entity
    {
        public int User_id { get; set; }

        public string payment_type { get; set; }

        public int Account_no { get; set; }

        public DateTime Expiry { get; set; }

        public User User { get; set; }

    }
}
