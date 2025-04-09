using StrategyPattern.Interface;
using StrategyPattern.ConcreteStrategies;

namespace StrategyPattern;

public class RouteFactory
{
    public static IRouteStrategy GetRouteStrategy(string routeType)
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
        
        return routeStrategy;
    }
}