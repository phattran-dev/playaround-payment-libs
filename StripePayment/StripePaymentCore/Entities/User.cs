using Microsoft.AspNetCore.Identity;
using StripePaymentCore.Entities.BaseEntities;

namespace StripePaymentCore.Entities
{
    public class User : IdentityUser<Guid>, IEntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
