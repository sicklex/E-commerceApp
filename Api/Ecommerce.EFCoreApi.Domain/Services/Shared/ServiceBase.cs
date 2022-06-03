using Ecommerce.EFCoreApi.Domain.Entities.Shared;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories.Shared;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services.Shared;

namespace Ecommerce.EFCoreApi.Domain.Services.Shared
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase) =>
      _repositoryBase = repositoryBase;

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _repositoryBase.GetAllAsync();

        public virtual async Task<object> AddAsync(TEntity entity) => await _repositoryBase.AddAsync(entity);

        public Task<TEntity> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose() => _repositoryBase.Dispose();


        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}