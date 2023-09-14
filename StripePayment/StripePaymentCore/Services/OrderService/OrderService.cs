using StripePaymentData;
using StripePaymentData.Entities;
using StripePaymentData.Repositories.RepositoryBase;
using StripePaymentData.UnitOfWorks;

namespace StripePaymentCore.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<PaymentDbContext, Order, Guid> _orderRepository;
        private readonly IUnitOfWork<PaymentDbContext> _unitOfWork;
        public OrderService(IUnitOfWork<PaymentDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _orderRepository = unitOfWork.GetRepository<Order, Guid>();
        }
        public async Task AddOrderAsync(Order order)
        {
            var existedOrder = await _orderRepository.GetByIdAsync(order.Id);
            if (existedOrder == null)
                throw new ArgumentNullException("The order is not existed.");

            await _orderRepository.AddAsync(order);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteOrderAsync(Order order)
        {
            var existedOrder = await _orderRepository.GetByIdAsync(order.Id);
            if (existedOrder == null)
                throw new ArgumentNullException("The order is not existed.");

            _orderRepository.Delete(order);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            var existedOrder = await _orderRepository.GetByIdAsync(order.Id);
            if (existedOrder == null)
                throw new ArgumentNullException("The order is not existed.");

            _orderRepository.Update(order);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
