using TemplateMethodPattern.AbstractTemplate;

namespace TemplateMethodPattern.ConcreteSubclasses;

public class CoffeeMaker : DrinkMakerTemplate
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing coffee...");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk...");
    }
    
}