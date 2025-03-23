using ProxyPatterm.ENUM;
using ProxyPatterm.Model;

namespace ProxyPatterm.Service;

public class AuthenticationService
{
    public bool IsAuthenticated(User user)
    {
        // Simulate authentication check
        return user.isAuthenticated;
    }

    public bool HasAccess(User user, string videoId)
    {
        // Simulate access check based on subscription
        if (user.subscriptionType == SUBSCRIPTIONTYPE.PREMIUM)
        {
            return true; // Premium users have access to all videos
        }

        // Standard users may only access non-premium content
        return !videoId.Contains("premium");
    }
}