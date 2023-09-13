using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StripePaymentData.Repositories.RepositoryBase;
using StripePaymentData.UnitOfWorks;

namespace StripePaymentData
{
    public static class StartUp
    {
        public static void AddPaymentDbContext(this IServiceCollection services, string dbConnectionString)
        {
            services.AddDbContext<PaymentDbContext>(o => o.UseSqlServer(dbConnectionString,
                options => options.EnableRetryOnFailure()));
            services.AddScoped(typeof(IRepository<,,>), typeof(Repository<,,>));
            services.AddScoped<IUnitOfWork<PaymentDbContext>>(provider => new UnitOfWork<PaymentDbContext>(provider));
        }
    }
}
