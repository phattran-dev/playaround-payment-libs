using StripePaymentData.Entities;

namespace StripePaymentCore.Services.OrderService
{
    public interface IOrderService
    {
        Task AddOrderAsync(OrderEntity order);
        Task UpdateOrderAsync(OrderEntity order);
        Task DeleteOrderAsync(OrderEntity order);
    }
}
