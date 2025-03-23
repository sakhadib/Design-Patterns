using AdapterPattern.Interface;
using AdapterPattern.ThirdParty;

namespace AdapterPattern.Adapter;

public class PaypalAdapter : IPaymentAdapter
{
    private readonly string _email;
    
    public PaypalAdapter(string email)
    {
        _email = email;
    }

    public void ProcessPayment(double amount)
    {
        var paypalPayment = new PaypalPayment();
        paypalPayment.ProcessPaypalPayment(_email, amount);
    }
    
}