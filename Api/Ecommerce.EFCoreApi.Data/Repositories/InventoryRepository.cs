using Ecommerce.EFCoreApi.Data.Context;
using Ecommerce.EFCoreApi.Data.Repositories.Shared;
using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories;

namespace Ecommerce.EFCoreApi.Data.Repositories
{
    public class InventoryRepository : RepositoryBase<ProductInventory>, IIventoryRepository
    {
        public InventoryRepository(DataContext context) : base(context) { }
    }
}