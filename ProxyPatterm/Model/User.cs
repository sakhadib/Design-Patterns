using ProxyPatterm.ENUM;

namespace ProxyPatterm.Model;

public class User
{
    public string userName { get; set; }
    public bool isAuthenticated { get; set; }
    public SUBSCRIPTIONTYPE subscriptionType { get; set; }
}