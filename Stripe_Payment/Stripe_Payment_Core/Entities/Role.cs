using Microsoft.AspNetCore.Identity;

namespace Stripe_Payment_Core.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public ICollection<UserRole> UserRoles { get; set;}
    }
}
