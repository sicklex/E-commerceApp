using DevInHouse.EFCoreApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public  class Categories : Entity
    {
        public string Name { get; set; }
        public ICollection<ProductCategories> Product_Categories { get; set; }
    }
}
