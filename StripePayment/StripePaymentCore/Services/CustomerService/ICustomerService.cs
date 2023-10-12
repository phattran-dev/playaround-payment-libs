using StripePaymentData.Entities;

namespace StripePaymentCore.Services.CustomerService
{
    public interface ICustomerService
    {
        Task AddOrderAsync(CustomerEntity customer);
        Task UpdateOrderAsync(CustomerEntity customer);
        Task DeleteOrderAsync(CustomerEntity customer);
    }
}
