using Ecommerce.EFCoreApi.Domain.Entities.Shared;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Cart : Entity
    {
        public int Quantity { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Modified_at { get; set; }

        public Session Session { get; set; }
        public int Session_Id { get; set; }
        public Product Product { get; set; }
        public int Product_id { get; set; }
    }
}