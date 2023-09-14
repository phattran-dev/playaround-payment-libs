using StripePaymentData;
using StripePaymentData.Entities;
using StripePaymentData.Repositories.RepositoryBase;
using StripePaymentData.UnitOfWorks;

namespace StripePaymentCore.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<PaymentDbContext, Customer, Guid> _customerRepository;
        private readonly IUnitOfWork<PaymentDbContext> _unitOfWork;
        public CustomerService(IUnitOfWork<PaymentDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = unitOfWork.GetRepository<Customer, Guid>();
        }
        public async Task AddOrderAsync(Customer customer)
        {
            var existedCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            if (existedCustomer == null)
                throw new ArgumentNullException("The order is not existed.");

            await _customerRepository.AddAsync(customer);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteOrderAsync(Customer customer)
        {
            var existedCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            if (existedCustomer == null)
                throw new ArgumentNullException("The order is not existed.");

            _customerRepository.Delete(customer);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task UpdateOrderAsync(Customer customer)
        {
            var existedCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            if (existedCustomer == null)
                throw new ArgumentNullException("The order is not existed.");

            _customerRepository.Update(customer);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
