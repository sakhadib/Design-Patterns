using ProxyPatterm.Interfaces;
using ProxyPatterm.Model;
using ProxyPatterm.Service;

namespace ProxyPatterm.Proxy;

public class VideoStreamProxy : IVedioStream
{
    private VideoStreamer _realVideoStream;
    private Cache _cache;
    private AuthenticationService _authService;
    private ServerManager _serverManager;

    public VideoStreamProxy()
    {
        _realVideoStream = new VideoStreamer();
        _cache = new Cache();
        _authService = new AuthenticationService();
        _serverManager = new ServerManager();
    }

    public void StreamVideo(string videoId, User user)
    {
        // 1. Authenticate user
        if (!_authService.IsAuthenticated(user))
        {
            Console.WriteLine("User authentication failed. Access denied.");
            return;
        }

        // 2. Check for user access based on subscription (premium or standard)
        if (!_authService.HasAccess(user, videoId))
        {
            Console.WriteLine("User does not have access to this content.");
            return;
        }

        // 3. Check cache for the video
        if (_cache.IsVideoCached(videoId))
        {
            Console.WriteLine($"Serving cached video: {videoId} to {user.userName}");
            _cache.GetVideo(videoId);
        }
        else
        {
            // 4. Choose the appropriate server based on user location or network speed
            string server = _serverManager.GetOptimalServer(videoId, user);
            Console.WriteLine($"Fetching video from server: {server}");

            // 5. Stream the video through the real service
            _realVideoStream.StreamVideo(videoId, user);

            // 6. Cache the video for future use
            _cache.CacheVideo(videoId);
        }
    }
}