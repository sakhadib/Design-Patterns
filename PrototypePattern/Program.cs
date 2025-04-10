using PrototypePattern.Concrete;
using PrototypePattern.Interfaces;

class main
{
    public static void Main(string[] args)
    {
        Ishape circle = new Circle("Red", "Circle1");
        Ishape square = new Square("Blue", "Square1");
        
        // Cloning the shapes
        Ishape clonedCircle = circle.Clone();
        Ishape clonedSquare = square.Clone();
        
        // Changing the color of the cloned shapes
        clonedCircle.SetColor("Green");
        clonedSquare.SetColor("Yellow");
        
        // Drawing the original and cloned shapes
        Console.WriteLine("Original Shapes:");
        circle.Draw();
        square.Draw();
        
        Console.WriteLine("Cloned Shapes:");
        clonedCircle.Draw();
        clonedSquare.Draw();
    }
}