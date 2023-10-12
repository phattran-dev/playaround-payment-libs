using StripePaymentData.UnitOfWorks;
using StripePaymentData;

namespace StripePaymentCore.Services
{
    public class BaseService
    {
        public readonly IUnitOfWork<PaymentDbContext> _unitOfWork;
        public BaseService(IUnitOfWork<PaymentDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
