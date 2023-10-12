using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StripePaymentData
{
    public class PaymentDbContextFactory : IDesignTimeDbContextFactory<PaymentDbContext>
    {
        public PaymentDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaymentDbContext>();
            //optionsBuilder.UseSqlServer(args[0]);
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=PaymentDb;Persist Security Info=False;User ID=sa;Password=ThienHoa0096@@;MultipleActiveResultSets=False;Encrypt=false;TrustServerCertificate=true;Connection Timeout=30;");

            return new PaymentDbContext(optionsBuilder.Options);
        }
    }
}
