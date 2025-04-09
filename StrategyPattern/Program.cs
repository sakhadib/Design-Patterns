using StrategyPattern;
using StrategyPattern.ConcreteStrategies;
using StrategyPattern.ContextClass;
using StrategyPattern.Interface;

class main
{
    public static void Main(string[] args)
    {
        IRouteStrategy routeStrategy = RouteFactory.GetRouteStrategy("air");

        if (routeStrategy != null)
        {
            RouteFinder routeFinder = new RouteFinder(routeStrategy);
            routeFinder.FindRoute();
        }
        else
        {
            Console.WriteLine("Route strategy not set.");
        }
        
        Console.ReadKey();
    }
}