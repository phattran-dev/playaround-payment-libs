using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Entities
{
    public class CustomerEntity : FullAuditedEntityBase<User, Guid>
    {
        public string Code { get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
    }
}
