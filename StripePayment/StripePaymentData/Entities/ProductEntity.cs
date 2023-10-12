using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Entities
{
    public class ProductEntity : FullAuditedEntityBase<User, Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderItemEntity> OrderItems { get; set; }
    }
}
