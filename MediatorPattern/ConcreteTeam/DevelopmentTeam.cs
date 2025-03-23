using MediatorPattern.Interface;

namespace MediatorPattern.ConcreteTeam;

public class DevelopmentTeam : ITeam
{
    private IMediator _mediator;
    
    public DevelopmentTeam(IMediator mediator)
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
        Console.WriteLine($"Development Team received message: {message}");
    }
}