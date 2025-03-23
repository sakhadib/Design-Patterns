namespace AdapterPattern.ThirdParty;

public class CreditCardPayment
{
    public void ProcessCreditCardPayment(string cardNumber, string expiryDate, string securityCode, double amount)
    {
        Console.WriteLine($"Processing payment of ${amount} using Credit Card. Card Number: {cardNumber}, Expiry Date: {expiryDate}");
    }
}