using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StripePaymentCore.Entities;
using StripePaymentData.Configurations;

namespace StripePaymentData
{
    public class PaymentDbContext : IdentityDbContext<User, Role, Guid>
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options) { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(CustomerEntityTypeConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ProductEntityTypeConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderEntityTypeConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderItemEntityTypeConfiguration).Assembly);
        }
    }
}
