using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Entities
{
    public class Product : FullAuditedEntityBase<User, Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
