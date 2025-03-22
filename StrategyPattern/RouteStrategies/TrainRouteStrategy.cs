using StrategyPattern.Interface;

namespace StrategyPattern.ConcreteStrategies;

public class TrainRouteStrategy : IRouteStrategy
{
    public void Execute()
    {
        Console.WriteLine("Calculating train route...");
    }
}