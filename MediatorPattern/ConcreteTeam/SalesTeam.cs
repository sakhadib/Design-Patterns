using MediatorPattern.Interface;

namespace MediatorPattern.ConcreteTeam;

public class SalesTeam : ITeam
{
    private IMediator _mediator;
    
    public SalesTeam(IMediator mediator)
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
        Console.WriteLine($"Sales Team received message: {message}");
    }
    
}