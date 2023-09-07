using StripePaymentCore.Entities.EntitesBase;

namespace StripePaymentCore.Entities
{
    public class OrderItem : EntityBase<Guid>
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal CurrentPrice { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
