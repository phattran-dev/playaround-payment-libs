using StripePaymentData.Entities;

namespace StripePaymentCore.Services.CustomerService
{
    public interface ICustomerService
    {
        Task AddOrderAsync(Customer customer);
        Task UpdateOrderAsync(Customer customer);
        Task DeleteOrderAsync(Customer customer);
    }
}
