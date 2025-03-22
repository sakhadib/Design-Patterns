using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.RouteStrategies;

public class WalkingRouteStrategy : IRouteStrategy
{
    public void FindRoute()
    {
        Console.WriteLine("Finding route for walking...");
    }
}