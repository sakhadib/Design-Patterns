using DecoratorPattern.Base;

namespace DecoratorPattern.ConcreteComponent;

public class IceCoffeeComponent : Coffee
{
    public override string Brew()
    {
        return "Brewing ice coffee...";
    }

    public override double GetCost()
    {
        return 7.0;
    }
}