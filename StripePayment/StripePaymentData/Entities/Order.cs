using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Entities
{
    public class Order : FullAuditedEntityBase<User, Guid>
    {
        public Guid CustomerId { get; set; }
        public string Code { get; set; }
        public string Noted { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
