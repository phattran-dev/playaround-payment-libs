using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StripePaymentData.Entities;
using StripePaymentData.Configurations.BaseConfiguration;

namespace StripePaymentData.Configurations
{
    public class ProductEntityTypeConfiguration : FullAuditedEntityTypeConfigurationBase<ProductEntity, Guid>
    {
        public override void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Price)
                .HasColumnType("money");

            builder.HasMany(x => x.OrderItems)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
