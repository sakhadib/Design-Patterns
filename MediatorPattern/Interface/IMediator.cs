namespace MediatorPattern.Interface;

public interface IMediator
{
    void RegisterTeam(ITeam team);
    void SendMessage(string message, ITeam sender);
}