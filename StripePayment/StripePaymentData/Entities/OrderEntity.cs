using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Entities
{
    public class OrderEntity : FullAuditedEntityBase<User, Guid>
    {
        public Guid CustomerId { get; set; }
        public string Code { get; set; }
        public string Noted { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual CustomerEntity Customer { get; set; }
        public ICollection<OrderItemEntity> OrderItems { get; set; }
        public virtual ICollection<PaymentProcessEntity> PaymentProcesses { get; set; }
    }
}
