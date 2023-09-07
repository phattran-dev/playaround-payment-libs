namespace StripePaymentCore.Entities.BaseEntities
{
    public interface IEntityBase<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
