using PrototypePattern.Interfaces;

namespace PrototypePattern.Concrete;

public class Circle : Ishape
{
    private string _color;
    private string _name;
    
    public Circle(string color, string name)
    {
        _color = color;
        _name = name;
    }
    
    public void Draw()
    {
        Console.WriteLine($"Drawing a circle with color {_color} and name {_name}");
    }
    
    public void SetColor(string color)
    {
        _color = color;
    }
    
    public string GetColor()
    {
        return _color;
    }
    
    public string GetName()
    {
        return _name;
    }
    
    public Ishape Clone()
    {
        return new Circle(_color, _name);
    }
}