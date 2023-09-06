using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Stripe_Payment_Core
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DbContext>
    {
        public DbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=StripePayment;Persist Security Info=True;Integrated Security=true;");

            return new DbContext(optionsBuilder.Options);
        }
    }
}
