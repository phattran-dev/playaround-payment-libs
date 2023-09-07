using StripePaymentCore.Entities.BaseEntities;

namespace StripePaymentCore.Entities.EntitesBase
{
    public interface IAudited<TUser> 
        where TUser : IEntityBase<Guid>
    {
        public Guid? CreatedById { get; set; }
        public TUser CreatedBy { get; set; }
        public DateTime? CreatedDateUtc { get; set; }
        public Guid? UpdatedById { get; set; }
        public TUser UpdatedBy { get; set; }
        public DateTime? UpdateDateUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
