namespace Stripe_Payment_Core.Entities
{
    public class Customer : EntityBase<Guid>
    {
        public string CustomerCode { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
