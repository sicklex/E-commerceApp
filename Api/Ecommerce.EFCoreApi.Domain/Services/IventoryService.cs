using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services;
using Ecommerce.EFCoreApi.Domain.Services.Shared;

namespace Ecommerce.EFCoreApi.Domain.Services
{
    public class InventoryService : ServiceBase<ProductInventory>, IIventoryService
    {
        public InventoryService(IIventoryRepository repository) : base(repository) { }
    }
}