namespace StripePaymentData.Entities.BaseEntities
{
    public interface IEntityBase<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
