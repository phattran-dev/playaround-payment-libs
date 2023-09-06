using Stripe_Payment_Core.Enum;

namespace Stripe_Payment_Core.Entities
{
    public class Order : EntityBase
    {
        public Guid CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
