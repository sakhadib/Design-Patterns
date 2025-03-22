using DecoratorPattern.Base;

namespace DecoratorPattern.ConcreteComponent;

public class SimpleCoffeeComponent : Coffee
{
    public override string Brew()
    {
        return "Brewing simple coffee...";
    }

    public override double GetCost()
    {
        return 5.0;
    }
    
}