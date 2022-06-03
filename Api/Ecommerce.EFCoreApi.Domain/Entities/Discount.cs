using Ecommerce.EFCoreApi.Domain.Entities.Shared;
namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Discount : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Discount_Percent { get; set; }

        public DateTime Created_at { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
