using DevInHouse.EFCoreApi.Core.Entities;

namespace Ecommerce.EFCoreApi.Domain.Interfaces.Services.Shared
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<object> AddAsync(TEntity entity);

        Task<object> UpdateAsync(TEntity entity);

        Task<object> DeleteByIdAsync(int id);

    }
}