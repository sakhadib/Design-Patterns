using ProxyPatterm.Model;

namespace ProxyPatterm.Service;

public class ServerManager
{
    public string GetOptimalServer(string videoId, User user)
    {
        // Simulate server selection based on user location or internet speed
        return "Server1"; // In a real system, this would consider factors like speed and load
    }
}