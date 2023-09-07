using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StripePaymentCore.Entities;
using StripePaymentData.Configurations.BaseConfiguration;

namespace StripePaymentData.Configurations
{
    public class ProductEntityTypeConfiguration : FullAuditedEntityTypeConfigurationBase<Product, Guid>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
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
