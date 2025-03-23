namespace ProxyPatterm.Service;

public class Cache
{
    private HashSet<string> _cachedVideos;
    
    public Cache()
    {
        Console.WriteLine("Initializing cache...");
        _cachedVideos = new HashSet<string>();
    }

    public bool IsVideoCached(string videoId)
    {
        return _cachedVideos.Contains(videoId);
    }

    public void CacheVideo(string videoId)
    {
        _cachedVideos.Add(videoId);
        Console.WriteLine($"Caching video: {videoId}");
    }

    public void GetVideo(string videoId)
    {
        Console.WriteLine($"Retrieving video from cache: {videoId}");
    }
}