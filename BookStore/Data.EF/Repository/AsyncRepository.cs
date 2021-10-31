using Data.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.EF.Repository
{
    public class AsyncRepository<TEntity> : IAsyncRepository<TEntity> where TEntity : Entity
    {
        private readonly BookStoreDbContext _dbContext;

        public AsyncRepository(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity, string createdBy)
        {
            var result = await _dbContext.Set<TEntity>().AddAsync(entity);
            return result;
        }

        public void Update(TEntity entity, string updatedBy)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public void Remove(TEntity entity)
        {
            var existingEntity = _dbContext.Set<TEntity>().Find(entity.Id);

            if (existingEntity != null)
                _dbContext.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> Get()
        {
            return _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public async Task<int> CountAsync()
        {
            return await _dbContext.Set<TEntity>().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().CountAsync(predicate);
        }
    }
}
