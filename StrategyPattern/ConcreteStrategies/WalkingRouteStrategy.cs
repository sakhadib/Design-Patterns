using StrategyPattern.Interface;

namespace StrategyPattern.ConcreteStrategies;

public class WalkingRouteStrategy : IRouteStrategy
{
    public void Execute()
    {
        Console.WriteLine("Calculating walking route...");
    }
}