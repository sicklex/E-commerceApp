using Ecommerce.EFCoreApi.Domain.Entities.Shared;
namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Categories : Entity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }


        public Categories(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
