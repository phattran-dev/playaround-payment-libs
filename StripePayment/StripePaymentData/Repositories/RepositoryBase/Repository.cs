using Microsoft.EntityFrameworkCore;
using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Repositories.RepositoryBase
{
    public class Repository<TDbContext, TEntity, TKey> : IRepository<TDbContext, TEntity, TKey>
        where TDbContext : DbContext
        where TEntity : EntityBase<TKey>
    {
        protected readonly TDbContext _context;
        protected DbSet<TEntity> _dbSet => _context.Set<TEntity>();

        public Repository(TDbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = (await _dbSet.AddAsync(entity)).Entity;
            return result;
        }

        public async Task<IList<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            return entities.ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AttachRange(entities);
            _context.Entry(entities).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
            }
            _dbSet.RemoveRange(entities);
        }
    }
}
