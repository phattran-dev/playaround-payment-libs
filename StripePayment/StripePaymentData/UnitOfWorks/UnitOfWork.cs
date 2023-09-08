using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StripePaymentData.Entities.EntitesBase;
using StripePaymentData.Repositories.RepositoryBase;

namespace StripePaymentData.UnitOfWorks
{
    public class UnitOfWork<TDbContext> : IUnitOfWork<TDbContext> where TDbContext : DbContext
    {
        protected readonly IServiceProvider _serviceProvider;
        protected readonly TDbContext _dbContext;
        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _dbContext = serviceProvider.GetService<TDbContext>() ?? throw new NotImplementedException($"Not implemented the type {typeof(TDbContext)}");
        }

        public IRepository<TDbContext, TEntity, TKey> GetRepository<TEntity, TKey>() where TEntity : EntityBase<TKey>
        {
            return _serviceProvider?.GetService<IRepository<TDbContext, TEntity, TKey>>() ?? throw new NotImplementedException($"Not implemented the type {typeof(IRepository<TDbContext, TEntity, TKey>)}");
        }
        public TDbContext DbContext { get { return _dbContext; } }

        public void Dispose()
        {
            DbContext.Dispose();
        }
        public async Task DisposeAsync()
        {
            await DbContext.DisposeAsync();
        }
        public int SaveChange()
        {
            return _dbContext.SaveChanges();
        }
        public async Task<int> SaveChangeAsync()
        {
            return await DbContext.SaveChangesAsync();
        }
    }
}
