using MediatorPattern.Interface;

namespace MediatorPattern.ConcreteTeam;

public class MarketingTeam : ITeam
{
    private IMediator _mediator;
    
    public MarketingTeam(IMediator mediator)
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
        Console.WriteLine($"Marketing Team received message: {message}");
    }
    
}