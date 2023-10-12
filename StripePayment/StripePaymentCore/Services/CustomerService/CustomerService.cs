using StripePaymentData;
using StripePaymentData.Entities;
using StripePaymentData.Repositories.RepositoryBase;
using StripePaymentData.UnitOfWorks;

namespace StripePaymentCore.Services.CustomerService
{
    public class CustomerService : BaseService, ICustomerService
    {
        private readonly IRepository<PaymentDbContext, CustomerEntity, Guid> _customerRepository;
        public CustomerService(IUnitOfWork<PaymentDbContext> unitOfWork) : base(unitOfWork)
        {
            _customerRepository = unitOfWork.GetRepository<CustomerEntity, Guid>();
        }
        public async Task AddOrderAsync(CustomerEntity customer)
        {
            var existedCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            if (existedCustomer == null)
                throw new ArgumentNullException("The order is not existed.");

            await _customerRepository.AddAsync(customer);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteOrderAsync(CustomerEntity customer)
        {
            var existedCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            if (existedCustomer == null)
                throw new ArgumentNullException("The order is not existed.");

            _customerRepository.Delete(customer);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task UpdateOrderAsync(CustomerEntity customer)
        {
            var existedCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            if (existedCustomer == null)
                throw new ArgumentNullException("The order is not existed.");

            _customerRepository.Update(customer);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
