using StripePaymentData.Entities.EntitesBase;
using StripePaymentData.Repositories.RepositoryBase;

namespace StripePaymentData.UnitOfWorks
{
    public interface IUnitOfWork<TDbContext> : IDisposable
    {
        TDbContext DbContext { get; }
        IRepository<TDbContext, TEntity, TKey> GetRepository<TEntity, TKey>() where TEntity : EntityBase<TKey>;
        Task DisposeAsync();
        int SaveChange();
        Task<int> SaveChangeAsync();
    }
}
