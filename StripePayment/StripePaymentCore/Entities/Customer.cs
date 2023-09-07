using StripePaymentCore.Entities.EntitesBase;

namespace StripePaymentCore.Entities
{
    public class Customer : FullAuditedEntityBase<User, Guid>
    {
        public string Code { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
