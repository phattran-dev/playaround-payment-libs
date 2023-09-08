namespace StripePaymentCore.Models.PaymentService
{
    public class StripeConfig
    {
        public string? SecretKey { get; set; }
        public string? WebhookEndpointSecret { get; set; }
        public string? RedirectDomainUrl { get; set; }
    }
}
