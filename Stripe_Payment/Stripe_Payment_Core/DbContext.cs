using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stripe_Payment_Core.Entities;

namespace Stripe_Payment_Core
{
    public class DbContext : IdentityDbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
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
            Setup(builder.Entity<User>());
            Setup(builder.Entity<Role>());
            Setup(builder.Entity<UserRole>());
            Setup(builder.Entity<Customer>());
            Setup(builder.Entity<Product>());
            Setup(builder.Entity<Order>());
        }

        private void Setup(EntityTypeBuilder<User> entityConfig)
        {
            entityConfig.HasKey(x => x.Id);
        }

        private void Setup(EntityTypeBuilder<Role> entityConfig)
        {
            entityConfig.HasKey(x => x.Id);
        }

        private void Setup(EntityTypeBuilder<UserRole> entityConfig)
        {
            entityConfig.HasOne(x => x.Role)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.RoleId);

            entityConfig.HasOne(x => x.User)
                .WithOne(x => x.UserRole);
        }

        private void Setup(EntityTypeBuilder<Customer> entityConfig)
        {
            entityConfig.HasKey(x => x.Id);

            entityConfig.HasOne(x => x.User)
                .WithOne(x => x.Customer);
        }
        
        private void Setup(EntityTypeBuilder<Product> entityConfig)
        {
            entityConfig.HasKey(x => x.Id);

            entityConfig.HasMany(x => x.OrderItems)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
        }
        private void Setup(EntityTypeBuilder<Order> entityConfig)
        {
            entityConfig.HasKey(x => x.Id);

            entityConfig.HasMany(x => x.OrderItems)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);
        }
        private void Setup(EntityTypeBuilder<OrderItem> entityConfig)
        {
            entityConfig.HasKey(x => x.Id);

            entityConfig.HasOne(x => x.Order)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.OrderId);

            entityConfig.HasOne(x => x.Product)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.ProductId);
        }

    }
}
