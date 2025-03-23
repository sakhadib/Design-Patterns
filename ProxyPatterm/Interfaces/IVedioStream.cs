using ProxyPatterm.Model;

namespace ProxyPatterm.Interfaces;

public interface IVedioStream
{
    void StreamVideo(string videoId, User user);
}