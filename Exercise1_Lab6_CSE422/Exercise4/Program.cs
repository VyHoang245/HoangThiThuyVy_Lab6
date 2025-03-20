using Exercise4;

class Program
{
    static void Main()
    {
        Console.Write("Enter payment method (creditcard, paypal, crypto): ");
        string method = Console.ReadLine();

        try
        {
            IPaymentStrategy paymentMethod = PaymentFactory.GetPaymentMethod(method);
            PaymentService paymentService = new PaymentService(paymentMethod);
            paymentService.ProcessPayment(100.0);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
