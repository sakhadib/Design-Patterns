using PrototypePattern.Interfaces;

namespace PrototypePattern.Concrete;

public class Square : Ishape
{
    private string _color;
    private string _name;
    
    public Square(string color, string name)
    {
        _color = color;
        _name = name;
    }
    
    public void Draw()
    {
        Console.WriteLine($"Drawing a square with color {_color} and name {_name}");
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
        return new Square(_color, _name);
    }
    
}