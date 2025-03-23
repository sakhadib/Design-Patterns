using AdapterPattern.Interface;
using AdapterPattern.ThirdParty;

namespace AdapterPattern.Adapter;

public class StripeAdapter : IPaymentAdapter
{
    private readonly string _cardNumber;
    private readonly string _expiryDate;
    
    public StripeAdapter(string cardNumber, string expiryDate)
    {
        _cardNumber = cardNumber;
        _expiryDate = expiryDate;
    }

    public void ProcessPayment(double amount)
    {
        var stripePayment = new StripePayment();
        stripePayment.ProcessStripePayment(_cardNumber, _expiryDate, amount);
    }
    
}