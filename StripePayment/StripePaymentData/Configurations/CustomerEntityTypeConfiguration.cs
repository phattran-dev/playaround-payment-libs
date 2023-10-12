﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StripePaymentData.Entities;
using StripePaymentData.Configurations.BaseConfiguration;

namespace StripePaymentData.Configurations
{
    public class CustomerEntityTypeConfiguration : FullAuditedEntityTypeConfigurationBase<CustomerEntity, Guid>
    {
        public override void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Orders)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
