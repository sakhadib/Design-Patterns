using DecoratorPattern.Base;
using DecoratorPattern.BaseDecorator;

namespace DecoratorPattern.ConcreteDecorator;

public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(Coffee coffee) : base(coffee)
    {
    }

    public override string Brew()
    {
        return base.Brew() + " with whipped cream";
    }

    public override double GetCost()
    {
        return base.GetCost() + 1.5;
    }
    
}