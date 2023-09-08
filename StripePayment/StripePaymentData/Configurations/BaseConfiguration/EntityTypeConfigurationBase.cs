using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StripePaymentData.Entities;
using StripePaymentData.Entities.EntitesBase;

namespace StripePaymentData.Configurations.BaseConfiguration
{
    public class EntityTypeConfigurationBase<TEntity, TPrimaryKey> : IEntityTypeConfiguration<TEntity>
        where TEntity : EntityBase<TPrimaryKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }

    public class FullAuditedEntityTypeConfigurationBase<TEntity, TPrimary> : IEntityTypeConfiguration<TEntity>
        where TEntity : FullAuditedEntityBase<User, TPrimary>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasOne(x => x.CreatedBy)
                .WithMany()
                .HasForeignKey(x => x.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.UpdatedBy)
                .WithMany()
                .HasForeignKey(x => x.UpdatedById)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
