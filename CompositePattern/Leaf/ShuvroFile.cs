using CompositePattern.Interface;

namespace CompositePattern.Leaf;

public class ShuvroFile : IFileSystemComponent
{
    private readonly string _name;
    
    public ShuvroFile(string name)
    {
        _name = name;
    }
    
    public void Display(int indentLevel)
    {
        Console.WriteLine(new string(' ', indentLevel) + "[file] : " + _name);
    }
}