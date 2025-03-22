using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.RouteStrategies;

public class DrivingRouteStrategy : IRouteStrategy
{
    public void FindRoute()
    {
        Console.WriteLine("Finding route for driving...");
    }
}