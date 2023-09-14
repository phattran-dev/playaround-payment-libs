using Microsoft.Extensions.DependencyInjection;
using StripePaymentCore.Services.CustomerService;
using StripePaymentCore.Services.OrderService;
using StripePaymentCore.Services.PaymentService;
using StripePaymentCore.Services.ProductService;

namespace StripePaymentCore
{
    public static class Startup
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
