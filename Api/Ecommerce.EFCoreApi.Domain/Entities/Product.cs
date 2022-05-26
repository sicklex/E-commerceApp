using DevInHouse.EFCoreApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int Quantities { get; set; }
        public int Product_Sku { get; set; }
        public ICollection<ProductCategories> Product_Categories { get; set; }
    }
}
