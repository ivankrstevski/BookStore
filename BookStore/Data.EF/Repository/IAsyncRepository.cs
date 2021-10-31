using Data.DomainModels;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.EF.Repository
{
    public interface IAsyncRepository<TEntity> where TEntity : Entity
    {
        ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity, string createdBy);
        void Update(TEntity entity, string updatedBy);
        void Remove(TEntity entity);
        IQueryable<TEntity> Get();
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
