using ProxyPatterm.Interfaces;

namespace ProxyPatterm.Service;

public class VideoStreamer : IVedioStream
{
    public void StreamVideo(string videoId, Model.User user)
    {
        Console.WriteLine($"Streaming video {videoId} for user {user.userName}");
    }
    
}