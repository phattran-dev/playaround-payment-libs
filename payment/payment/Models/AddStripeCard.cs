﻿namespace payment.Models
{
    public class AddStripeCard {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationYear { get; set; }
        public string ExpirationMonth { get; set; }
        public string CVC { get; set; }
    }
}
