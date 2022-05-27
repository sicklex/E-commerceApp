using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Session : Entity
    {
        public int User_Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Modified_At { get; set; }
        public User User { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}