using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class UserAddress : Entity
    {
        public int User_id { get; set; }
        public string Address_line1 { get; set; }

        public string Address_line2 { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public virtual User User { get; set; }

    }
}