namespace TemplateMethodPattern.AbstractTemplate;

public abstract class DrinkMakerTemplate
{
    /**
     * For all the drink types, the steps are the same. So, we can define the steps in the abstract class and make
     * them protected so that only the subclasses can access them.
     *
     * Boil Water is same for all drinks. so it has defined in the abstract class.
     */
    protected void BoilWater()
    {
        Console.WriteLine("Boiling water...");
    }
    
    /**
     * Brew and AddCondiments are different for different drinks. So, they are abstract methods and will be implemented
     * by the subclasses.
     */
    protected abstract void Brew();
    
    
    /**
     * PourInCup is same for all drinks. so it has defined in the abstract class.
     */
    protected void PourInCup()
    {
        Console.WriteLine("Pouring in cup...");
    }
    
    /**
     * Brew and AddCondiments are different for different drinks. So, they are abstract methods and will be implemented
     * by the subclasses.
     */
    protected abstract void AddCondiments();
    
    
    /**
     * Serve is same for all drinks. so it has defined in the abstract class.
     */
    protected void Serve()
    {
        Console.WriteLine("Serving...");
    }
    
    /**
     * This is the template method
     * previous methods are the steps of the algorithm and their access modifier is protected. So no outsider class
     * other than the subclasses can access them. The template method is public so that the client can call it.
     *
     * By this no inconsistency can be introduced by any client code for making a drink. always the same algorithm will
     * be followed.
     */
    public void MakeDrink()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
        Serve();
    }
}