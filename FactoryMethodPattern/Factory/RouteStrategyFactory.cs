using FactoryMethodPattern.Interface;
using FactoryMethodPattern.RouteStrategies;

namespace FactoryMethodPattern.Factory;

public static class RouteStrategyFactory
{
    public static IRouteStrategy CreateRouteStrategy(string strategy)
    {
        switch (strategy)
        {
            case "train":
                return new TrainRouteStrategy();
            case "air":
                return new AirRouteStrategy();
            case "walking":
                return new WalkingRouteStrategy();
            case "driving":
                return new DrivingRouteStrategy();
            default:
                throw new ArgumentException("Invalid route strategy");
        }
    }
}