using StripePaymentCore.Entities.BaseEntities;

namespace StripePaymentCore.Entities.EntitesBase
{
    public abstract class Audited<TUser> : IAudited<TUser>
        where TUser : IEntityBase<Guid>
    {
        public Guid? CreatedById { get; set; }
        public virtual TUser CreatedBy { get; set; }
        public DateTime? CreatedDateUtc { get; set; }
        public Guid? UpdatedById { get; set; }
        public virtual TUser UpdatedBy { get; set; }
        public DateTime? UpdateDateUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
