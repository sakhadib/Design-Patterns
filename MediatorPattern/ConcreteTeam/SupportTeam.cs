using MediatorPattern.Interface;

namespace MediatorPattern.ConcreteTeam;

public class SupportTeam : ITeam
{
    private IMediator _mediator;
    
    public SupportTeam(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public void SendMessage(string message)
    {
        _mediator.SendMessage(message, this);
    }
    
    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Support Team received message: {message}");
    }
    
}