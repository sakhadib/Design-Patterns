using StrategyPattern.Interface;

namespace StrategyPattern.ConcreteStrategies;

public class DrivingRouteStrategy : IRouteStrategy
{
    public void Execute()
    {
        Console.WriteLine("Calculating driving route...");
    }
}