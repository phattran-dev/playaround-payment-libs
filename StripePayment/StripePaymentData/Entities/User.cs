using Microsoft.AspNetCore.Identity;
using StripePaymentData.Entities.BaseEntities;

namespace StripePaymentData.Entities
{
    public class User : IdentityUser<Guid>, IEntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
