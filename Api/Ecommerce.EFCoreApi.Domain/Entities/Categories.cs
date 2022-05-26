﻿using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Entities
{
    public class Categories : Entity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}