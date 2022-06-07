using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services;
using Ecommerce.EFCoreApi.Domain.Services.Shared;

namespace Ecommerce.EFCoreApi.Domain.Services
{
    public class DiscountService : ServiceBase<Discount>, IDiscountService
    {
        public DiscountService(IDiscountRepository repository) : base(repository)
        {
        }

    }
}