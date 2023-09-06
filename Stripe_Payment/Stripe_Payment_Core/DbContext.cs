using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stripe_Payment_Core.Entities;
using Stripe_Payment_Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripe_Payment_Core
{
    public class DbContext : IdentityDbContext<User, Role, Guid>
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }
    }
}
