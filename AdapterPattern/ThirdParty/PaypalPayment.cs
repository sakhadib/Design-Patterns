namespace AdapterPattern.ThirdParty;

public class PaypalPayment
{
    public void ProcessPaypalPayment(string email, double amount)
    {
        Console.WriteLine($"Processing payment of ${amount} using Paypal. Email: {email}");
    }
}