using StripePaymentData.Entities;

namespace StripePaymentCore.Services.ProductService
{
    public interface IProductService
    {
        Task AddProductAsync(ProductEntity product);

        //Task AddProductsAsync(List<Product> products);

        //Task UpdateProductAsync(Product product);

        //Task UpdateProductsAsync(List<Product> products);

        Task DeleteProductAsync(Guid productId);

        //Task DeleteProductsAsyn(List<Guid> productIds);
    }
}
