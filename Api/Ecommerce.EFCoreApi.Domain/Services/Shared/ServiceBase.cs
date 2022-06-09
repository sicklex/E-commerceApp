using Ecommerce.EFCoreApi.Domain.Entities.Shared;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories.Shared;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services.Shared;

namespace Ecommerce.EFCoreApi.Domain.Services.Shared
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase) => _repositoryBase = repositoryBase;

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _repositoryBase.GetAllAsync();

        public virtual async Task<object> AddAsync(TEntity entity) => await _repositoryBase.AddAsync(entity);

        public virtual async Task DeleteByIdAsync(int id) => await _repositoryBase.DeleteByIdAsync(id);


        public virtual async Task<TEntity> GetByIdAsync(int id) => await _repositoryBase.GetByIdAsync(id);


        public virtual async Task UpdateAsync(TEntity entity) => await _repositoryBase.UpdateAsync(entity);


        public void Dispose() => _repositoryBase.Dispose();


    }
}