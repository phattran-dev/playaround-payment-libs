using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StripePaymentData.Entities;
using StripePaymentData.Configurations.BaseConfiguration;

namespace StripePaymentData.Configurations
{
    public class OrderItemEntityTypeConfiguration : EntityTypeConfigurationBase<OrderItemEntity, Guid>
    {
        public override void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.CurrentPrice)
                .HasColumnType("money");

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
