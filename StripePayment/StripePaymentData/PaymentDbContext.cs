using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StripePaymentData.Entities;
using StripePaymentData.Configurations;
using Microsoft.AspNetCore.Identity;

namespace StripePaymentData
{
    public class PaymentDbContext : IdentityDbContext<User, Role, Guid>
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options) { 
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(b => b.ToTable("Users"));
            builder.Entity<Role>(b => b.ToTable("Roles"));
            builder.Entity<IdentityUserRole<Guid>>(b => b.ToTable("UserRoles"));
            builder.Entity<IdentityUserClaim<Guid>>(b => b.ToTable("UserClaims"));
            builder.Entity<IdentityUserLogin<Guid>>(b => b.ToTable("UserLogins"));
            builder.Entity<IdentityUserToken<Guid>>(b => b.ToTable("UserTokens"));
            builder.Entity<IdentityRoleClaim<Guid>>(b => b.ToTable("RoleClaims"));

            builder.ApplyConfigurationsFromAssembly(typeof(CustomerEntityTypeConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ProductEntityTypeConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderEntityTypeConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderItemEntityTypeConfiguration).Assembly);
        }
    }
}
