using Stripe_Payment_Core.Enum;

namespace Stripe_Payment_Core.Entities
{
    public class UserRole
    {
        public Guid UserId { get; set; }
        public Role Role { get; set; }
    }
}
