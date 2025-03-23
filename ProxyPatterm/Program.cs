using ProxyPatterm.ENUM;
using ProxyPatterm.Interfaces;
using ProxyPatterm.Model;
using ProxyPatterm.Proxy;

class main
{
    public static void Main(string[] args)
    {
        // Creating users
        User standardUser = new User { userName = "Alice", isAuthenticated = true, subscriptionType = SUBSCRIPTIONTYPE.STANDARD };
        User premiumUser = new User { userName = "Bob", isAuthenticated = true, subscriptionType = SUBSCRIPTIONTYPE.PREMIUM };

        // Creating the proxy for video streaming
        IVedioStream videoStreamProxy = new VideoStreamProxy();

        // Simulating video requests
        Console.WriteLine("Requesting video for Standard User (standard_video_1):");
        videoStreamProxy.StreamVideo("standard_video_1", standardUser);

        Console.WriteLine("\nRequesting video for Premium User (premium_video_1):");
        videoStreamProxy.StreamVideo("premium_video_1", premiumUser);

        Console.WriteLine("\nRequesting video for Premium User (standard_video_1):");
        videoStreamProxy.StreamVideo("standard_video_1", premiumUser);
    }
}