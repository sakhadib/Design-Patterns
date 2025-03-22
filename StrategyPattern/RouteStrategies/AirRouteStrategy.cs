using StrategyPattern.Interface;

namespace StrategyPattern.ConcreteStrategies;

public class AirRouteStrategy : IRouteStrategy
{
    public void Execute()
    {
        Console.WriteLine("Calculating air route...");
    }
}