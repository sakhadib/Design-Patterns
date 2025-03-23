using MediatorPattern.ConcreteMediator;
using MediatorPattern.ConcreteTeam;
using MediatorPattern.Interface;

class main
{
    public static void Main(string[] args)
    {
        // Create the Mediator
        TeamMediator mediator = new TeamMediator();

        // Create the teams and set the mediator
        ITeam marketingTeam = new MarketingTeam(mediator);
        ITeam salesTeam = new SalesTeam(mediator);
        ITeam developmentTeam = new DevelopmentTeam(mediator);
        ITeam supportTeam = new SupportTeam(mediator);

        // Register teams with the mediator
        mediator.RegisterTeam(marketingTeam);
        mediator.RegisterTeam(salesTeam);
        mediator.RegisterTeam(developmentTeam);
        mediator.RegisterTeam(supportTeam);

        // Simulate sending messages between teams
        Console.WriteLine("Scenario 1: Marketing team needs help from Development team for a campaign.");
        marketingTeam.SendMessage("We need a new landing page for an upcoming campaign!");

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("\nScenario 2: Sales team requires help from Support team to resolve customer issues.");
        salesTeam.SendMessage("Please provide customer issue details for case 1122.");
        
        Console.WriteLine(new string('-', 50));

        Console.WriteLine("\nScenario 3: Development team asks for marketing input before finalizing a feature.");
        developmentTeam.SendMessage("We need marketing's input on the new feature for the product launch.");
    }
    
}