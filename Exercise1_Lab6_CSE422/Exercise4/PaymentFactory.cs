using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class PaymentFactory
    {
        public static IPaymentStrategy GetPaymentMethod(string method)
        {
            return method.ToLower() switch
            {
                "creditcard" => new CreditCardPayment(),
                "paypal" => new PayPalPayment(),
                "crypto" => new CryptoPayment(),
                _ => throw new ArgumentException("Invalid payment method")
            };
        }
    }

}
