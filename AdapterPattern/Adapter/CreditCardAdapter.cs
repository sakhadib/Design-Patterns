using AdapterPattern.Interface;
using AdapterPattern.ThirdParty;

namespace AdapterPattern.Adapter;

public class CreditCardAdapter : IPaymentAdapter
{
    private readonly string _cardNumber;
    private readonly string _expiryDate;
    private readonly string _securityCode;
    
    public CreditCardAdapter(string cardNumber, string expiryDate, string securityCode)
    {
        _cardNumber = cardNumber;
        _expiryDate = expiryDate;
        _securityCode = securityCode;
    }

    public void ProcessPayment(double amount)
    {
        var creditCardPayment = new CreditCardPayment();
        creditCardPayment.ProcessCreditCardPayment(_cardNumber, _expiryDate, _securityCode, amount);
    }
}