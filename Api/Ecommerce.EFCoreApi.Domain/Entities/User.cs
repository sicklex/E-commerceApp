using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class User : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }
        public DateTime Created_at { get; set; }

        public ICollection<UserAddress> UserAddresses { get; set; }
    }
}