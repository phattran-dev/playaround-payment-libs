using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Repositories.RepositoryBase
{
    public interface IRepository<TDbContext, TEntity, TKey>
        where TEntity : EntityBase<TKey>
    {
        IQueryable<TEntity> GetQueryable();
        Task<TEntity> GetByIdAsync(TKey id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<IList<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
