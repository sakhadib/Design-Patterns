namespace AdapterPattern.ThirdParty;

public class StripePayment
{
    public void ProcessStripePayment(string cardNumber, string expiryDate, double amount)
    {
        Console.WriteLine($"Processing payment of ${amount} using Stripe. Card Number: {cardNumber}, Expiry Date: {expiryDate}");
    }
}