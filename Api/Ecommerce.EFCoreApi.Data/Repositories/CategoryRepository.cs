using Ecommerce.EFCoreApi.Data.Context;
using Ecommerce.EFCoreApi.Data.Repositories.Shared;
using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories;

namespace Ecommerce.EFCoreApi.Data.Repositories
{
    public class CategoryRepository : RepositoryBase<Categories>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context) { }
    }
}