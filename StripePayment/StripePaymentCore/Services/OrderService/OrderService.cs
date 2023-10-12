using StripePaymentData;
using StripePaymentData.Entities;
using StripePaymentData.Repositories.RepositoryBase;
using StripePaymentData.UnitOfWorks;

namespace StripePaymentCore.Services.OrderService
{
    public class OrderService : BaseService, IOrderService
    {
        private readonly IRepository<PaymentDbContext, OrderEntity, Guid> _orderRepository;
        public OrderService(IUnitOfWork<PaymentDbContext> unitOfWork) : base(unitOfWork)
        {
            _orderRepository = unitOfWork.GetRepository<OrderEntity, Guid>();
        }
        public async Task AddOrderAsync(OrderEntity order)
        {
            var existedOrder = await _orderRepository.GetByIdAsync(order.Id);
            if (existedOrder == null)
                throw new ArgumentNullException("The order is not existed.");

            await _orderRepository.AddAsync(order);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteOrderAsync(OrderEntity order)
        {
            var existedOrder = await _orderRepository.GetByIdAsync(order.Id);
            if (existedOrder == null)
                throw new ArgumentNullException("The order is not existed.");

            _orderRepository.Delete(order);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task UpdateOrderAsync(OrderEntity order)
        {
            var existedOrder = await _orderRepository.GetByIdAsync(order.Id);
            if (existedOrder == null)
                throw new ArgumentNullException("The order is not existed.");

            _orderRepository.Update(order);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
