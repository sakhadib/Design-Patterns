using StrategyPattern.Interface;

namespace StrategyPattern.ContextClass;

public class RouteFinder
{
    private IRouteStrategy _routeStrategy;

    public RouteFinder(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }

    public void FindRoute()
    {
        _routeStrategy.Execute();
    }
    
    public void SetRouteStrategy(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
}