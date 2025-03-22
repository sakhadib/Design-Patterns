using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.RouteStrategies;

public class TrainRouteStrategy : IRouteStrategy
{
    public void FindRoute()
    {
        Console.WriteLine("Finding route for train travel...");
    }
}