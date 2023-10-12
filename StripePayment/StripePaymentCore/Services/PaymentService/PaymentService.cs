using StripePaymentData;
using StripePaymentData.Entities;
using StripePaymentData.Repositories.RepositoryBase;
using StripePaymentData.UnitOfWorks;
namespace StripePaymentCore.Services.PaymentService
{
    public class PaymentService : BaseService, IPaymentService
    {
        private readonly IRepository<PaymentDbContext, PaymentProcessEntity, Guid> _paymentProcessRepository;
        public PaymentService(IUnitOfWork<PaymentDbContext> unitOfWork,
            IRepository<PaymentDbContext, PaymentProcessEntity, Guid> paymentProcessRepository) : base(unitOfWork)
        {
            _paymentProcessRepository = paymentProcessRepository;
        }
    }
}
