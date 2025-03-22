using CompositePattern.Interface;

namespace CompositePattern.Composite;

public class Folder : IFileSystemComponent
{
    private readonly string _name;
    private readonly List<IFileSystemComponent> _children;

    public Folder(string name)
    {
        _name = name;
        _children = new List<IFileSystemComponent>();
    }

    public void Add(IFileSystemComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IFileSystemComponent component)
    {
        _children.Remove(component);
    }

    public void Display(int indentLevel)
    {
        Console.WriteLine(new string(' ', indentLevel) + "[folder] : " + _name);
        foreach (IFileSystemComponent child in _children)
        {
            child.Display(indentLevel + 4);
        }
    }
    
}