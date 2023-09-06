namespace Stripe_Payment_Core.Entities
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }

    public interface IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class EntityBase<T> : IEntity<T>, IAuditable
    {
        public T Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
