using StripePaymentData.Entities;

namespace StripePaymentCore.Services.OrderService
{
    public interface IOrderService
    {
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(Order order);
    }
}
