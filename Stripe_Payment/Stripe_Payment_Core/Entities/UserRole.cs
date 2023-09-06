using Microsoft.AspNetCore.Identity;

namespace Stripe_Payment_Core.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public Guid UserId { get; set; }
        public Role Role { get; set; }
    }
}
