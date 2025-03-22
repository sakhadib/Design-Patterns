using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.RouteStrategies;

public class AirRouteStrategy : IRouteStrategy
{
    public void FindRoute()
    {
        Console.WriteLine("Finding route for air travel...");
    }
}