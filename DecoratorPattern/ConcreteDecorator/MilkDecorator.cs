using DecoratorPattern.Base;
using DecoratorPattern.BaseDecorator;

namespace DecoratorPattern.ConcreteDecorator;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(Coffee coffee) : base(coffee)
    {
    }

    public override string Brew()
    {
        return base.Brew() + " with milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 1.0;
    }
    
}