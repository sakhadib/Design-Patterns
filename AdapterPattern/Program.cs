using AdapterPattern.Adapter;
using AdapterPattern.Interface;

class main
{
    public static void Main(string[] args)
    {
        IPaymentAdapter paymentProcessor = new StripeAdapter("4242424242424242", "12/25");
        paymentProcessor.ProcessPayment(100.00);
        
        paymentProcessor = new CreditCardAdapter("424242424", "12/25", "123");
        paymentProcessor.ProcessPayment(100.00);
        
        paymentProcessor = new PaypalAdapter("abc@abc.com");
        paymentProcessor.ProcessPayment(100.00);
    }
    
}