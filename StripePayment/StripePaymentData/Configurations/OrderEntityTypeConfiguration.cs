using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StripePaymentData.Entities;
using StripePaymentData.Configurations.BaseConfiguration;

namespace StripePaymentData.Configurations
{
    public class OrderEntityTypeConfiguration : FullAuditedEntityTypeConfigurationBase<OrderEntity, Guid>
    {
        public override void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.TotalPrice)
                .HasColumnType("money");

            builder.HasMany(x => x.OrderItems)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.PaymentProcesses)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
