using DecoratorPattern.Base;
using DecoratorPattern.BaseDecorator;

namespace DecoratorPattern.ConcreteDecorator;

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(Coffee coffee) : base(coffee)
    {
    }

    public override string Brew()
    {
        return base.Brew() + " with suger";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
    
}