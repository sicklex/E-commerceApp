using Ecommerce.EFCoreApi.Data.Context;
using Ecommerce.EFCoreApi.Data.Repositories.Shared;
using Ecommerce.EFCoreApi.Domain.Entities;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.EFCoreApi.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context) { }


        public async override Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Context.Products
                .Include(p => p.Categories)
                .Include(p => p.Inventory)
                .ToListAsync();
        }

        public async override Task<Product?> GetByIdAsync(int id)
        {
            return await Context.Products
                .Include(p => p.Categories)
                .FirstOrDefaultAsync(p => p.Id == id);

        }
    }
}