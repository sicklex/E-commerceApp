using Ecommerce.EFCoreApi.Data.Context;
using Ecommerce.EFCoreApi.Domain.Entities.Shared;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.EFCoreApi.Data.Repositories.Shared
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected readonly DataContext Context;

        public RepositoryBase(DataContext context) => Context = context;

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await Context.Set<TEntity>()
                .AsNoTracking()
                .ToListAsync();

        public virtual async Task<TEntity?> GetByIdAsync(int id) =>
            await Context.Set<TEntity>().FindAsync(id);


        public virtual async Task<object> AddAsync(TEntity entity)
        {

            Context.Add(entity);
            await Context.SaveChangesAsync();
            return entity.Id;
        }


        public virtual async Task UpdateAsync(TEntity entity)
        {

            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();


        }

        public virtual async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                throw new Exception("This item does not exist");

            await Context.SaveChangesAsync();
        }

        public void Dispose() => Context.Dispose();

    }
}