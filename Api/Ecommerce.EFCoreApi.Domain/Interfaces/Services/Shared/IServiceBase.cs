using Ecommerce.EFCoreApi.Domain.Entities.Shared;

namespace Ecommerce.EFCoreApi.Domain.Interfaces.Services.Shared
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);

        Task<object> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteByIdAsync(int id);
    }
}