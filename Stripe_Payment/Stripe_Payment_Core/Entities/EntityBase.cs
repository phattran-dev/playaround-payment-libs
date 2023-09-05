namespace Stripe_Payment_Core.Entities
{
    public abstract class EntityBase<T>
    {
        public T Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
