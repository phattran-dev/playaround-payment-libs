using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Entities
{
    public class OrderItemEntity : EntityBase<Guid>
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal CurrentPrice { get; set; }
        public Guid OrderId { get; set; }
        public virtual OrderEntity Order { get; set; }
        public virtual ProductEntity Product { get; set; }
    }
}
