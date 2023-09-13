using StripePaymentData;
using StripePaymentData.Entities;
using StripePaymentData.Repositories.RepositoryBase;
using StripePaymentData.UnitOfWorks;

namespace StripePaymentCore.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IRepository<PaymentDbContext, Product, Guid> _productRepository;
        private readonly IUnitOfWork<PaymentDbContext> _unitOfWork;
        public ProductService(IUnitOfWork<PaymentDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _productRepository = unitOfWork.GetRepository<Product, Guid>();
        }

        public async Task AddProductAsync(Product product)
        {
            var existedProduct = await _productRepository.GetByIdAsync(product.Id);
            if (existedProduct == null)
                throw new ArgumentNullException("The product is not exsited");

            await _productRepository.AddAsync(product);

            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteProductAsync(Guid productId)
        {
            var existedProduct = await _productRepository.GetByIdAsync(productId);
            if (existedProduct == null)
                throw new ArgumentNullException("The product is not exsited");

            _productRepository.Delete(existedProduct);

            await _unitOfWork.SaveChangeAsync();
        }
    }
}
