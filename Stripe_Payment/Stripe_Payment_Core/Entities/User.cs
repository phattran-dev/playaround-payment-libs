using Microsoft.AspNetCore.Identity;

namespace Stripe_Payment_Core.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
