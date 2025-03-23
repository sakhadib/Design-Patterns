using MediatorPattern.Interface;

namespace MediatorPattern.ConcreteMediator;

public class TeamMediator : IMediator
{
    private List<ITeam> _teams;
    
    public TeamMediator()
    {
        _teams = new List<ITeam>();
    }
    
    public void RegisterTeam(ITeam team)
    {
        _teams.Add(team);
    }
    
    public void SendMessage(string message, ITeam sender)
    {
        foreach (var team in _teams)
        {
            if (team != sender)
            {
                team.ReceiveMessage(message);
            }
        }
    }
}