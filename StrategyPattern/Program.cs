using StrategyPattern.ConcreteStrategies;
using StrategyPattern.ContextClass;
using StrategyPattern.Interface;

class main
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter route choice (air, train, walking, drive): ");
        
        string routeChoice = Console.ReadLine();
        
        IRouteStrategy routeStrategy = null;
        
        switch (routeChoice)
        {
            case "air":
                routeStrategy = new AirRouteStrategy();
                break;
            case "train":
                routeStrategy = new TrainRouteStrategy();
                break;
            case "walking":
                routeStrategy = new WalkingRouteStrategy();
                break;
            case "drive":
                routeStrategy = new DrivingRouteStrategy();
                break;
            default:
                Console.WriteLine("Invalid route choice.");
                break;
        }

        if (routeStrategy != null)
        {
            RouteFinder routeFinder = new RouteFinder(routeStrategy);
            routeFinder.FindRoute();
        }
        else
        {
            Console.WriteLine("Route strategy not set.");
        }
        
        Console.ReadKey();
    }
}