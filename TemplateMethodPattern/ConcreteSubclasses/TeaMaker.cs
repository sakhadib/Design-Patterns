using TemplateMethodPattern.AbstractTemplate;

namespace TemplateMethodPattern.ConcreteSubclasses;

public class TeaMaker : DrinkMakerTemplate
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea...");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon...");
    }
    
}