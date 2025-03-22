using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Context;

public class RouteFinder
{
    private IRouteStrategy _routeStrategy;
    
    public RouteFinder(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
    
    public void FindRoute()
    {
        _routeStrategy.FindRoute();
    }
    
    public void SetRouteStrategy(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
}