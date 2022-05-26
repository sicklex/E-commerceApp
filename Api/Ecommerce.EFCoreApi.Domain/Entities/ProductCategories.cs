using DevInHouse.EFCoreApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class ProductCategories : Entity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
