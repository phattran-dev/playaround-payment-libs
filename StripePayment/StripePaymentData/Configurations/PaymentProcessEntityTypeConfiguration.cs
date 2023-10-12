using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StripePaymentData.Configurations.BaseConfiguration;
using StripePaymentData.Entities;

namespace StripePaymentData.Configurations
{
    public class PaymentProcessEntityTypeConfiguration : EntityTypeConfigurationBase<PaymentProcessEntity, Guid>
    {
        public override void Configure(EntityTypeBuilder<PaymentProcessEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.PaymentProcesses)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
