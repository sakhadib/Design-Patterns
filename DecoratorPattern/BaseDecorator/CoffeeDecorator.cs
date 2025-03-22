using DecoratorPattern.Base;

namespace DecoratorPattern.BaseDecorator;

public class CoffeeDecorator : Coffee
{
    protected Coffee _coffee;
    
    public CoffeeDecorator(Coffee coffee)
    {
        _coffee = coffee;
    }
    
    public override string Brew()
    {
        return _coffee.Brew();
    }
    
    public override double GetCost()
    {
        return _coffee.GetCost();
    }
}