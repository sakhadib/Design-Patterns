namespace MediatorPattern.Interface;

public interface ITeam
{
    void SetMediator(IMediator mediator);
    void SendMessage(string message);
    void ReceiveMessage(string message);
}