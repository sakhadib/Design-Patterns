using DecoratorPattern.Base;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.BaseDecorator;
using DecoratorPattern.ConcreteDecorator;

class main
{
    public static void Main(string[] args)
    {
        // Iced Coffee
        Coffee myCoffee = new IceCoffeeComponent();
        Console.WriteLine(myCoffee.Brew());
        Console.WriteLine("Cost: $" + myCoffee.GetCost());

        // Coffee with Milk
        Coffee milkCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine(milkCoffee.Brew());
        Console.WriteLine("Cost: $" + milkCoffee.GetCost());

        // Coffee with Milk and Sugar
        Coffee milkSugarCoffee = new SugarDecorator(milkCoffee);
        Console.WriteLine(milkSugarCoffee.Brew());
        Console.WriteLine("Cost: $" + milkSugarCoffee.GetCost());

        // Coffee with Milk, Sugar, and Whipped Cream
        Coffee fullCoffee = new WhippedCreamDecorator(milkSugarCoffee);
        Console.WriteLine(fullCoffee.Brew());
        Console.WriteLine("Cost: $" + fullCoffee.GetCost());
        
        
    }
    
}