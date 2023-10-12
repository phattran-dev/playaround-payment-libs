using StripePaymentData.Entities.EntitesBase;
using StripePaymentData.Enums;

namespace StripePaymentData.Entities
{
    public class PaymentProcessEntity : EntityBase<Guid>
    {
        public string SessionId { get; set; }
        public Guid OrderId { get; set; }
        public PaymentStatus Status { get; set; }
        public virtual OrderEntity Order { get; set; }
    }
}
