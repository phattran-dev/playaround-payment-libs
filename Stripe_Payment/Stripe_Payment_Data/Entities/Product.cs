namespace Stripe_Payment_Core.Entities
{
    public class Product : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
