using Stripe_Payment_Core.Enum;

namespace Stripe_Payment_Core.Entities
{
    public class Order : EntityBase<Guid>
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
