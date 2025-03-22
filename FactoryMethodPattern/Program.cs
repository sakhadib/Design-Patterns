using FactoryMethodPattern.Context;
using FactoryMethodPattern.Factory;
using FactoryMethodPattern.Interface;

class main
{
    static void Main()
    {
        // Get the strategy from the user
        string strategy = Console.ReadLine();
        
        
        // Create the route strategy based on the user input using the factory
        IRouteStrategy routeStrategy = RouteStrategyFactory.CreateRouteStrategy(strategy);
        
        
        // Create the route finder with the route strategy
        RouteFinder routeFinder = new RouteFinder(routeStrategy);
        
        
        // Find the route
        routeFinder.FindRoute();
    }
    
}