using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Entities
{
    public class Customer : FullAuditedEntityBase<User, Guid>
    {
        public string Code { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
