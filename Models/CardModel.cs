using System;

namespace CreditCardModels
{
    public class CreditCard
    {
        public required string CardHolderName { get; set; }
        public required string CardNumber { get; set; }
        public required string ExpiryDate { get; set; }
        public required string CVV { get; set; }
    }
}
