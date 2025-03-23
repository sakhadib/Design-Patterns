using MediatorPattern.Interface;

namespace MediatorPattern.ConcreteTeam;

public class InformationTechnologyTeam : ITeam
{
    private IMediator _mediator;
    
    public InformationTechnologyTeam(IMediator mediator)
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
        Console.WriteLine($"Information Technology Team received message: {message}");
    }
    
}