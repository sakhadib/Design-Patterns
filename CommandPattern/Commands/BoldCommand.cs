using CommandPattern.Core;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class BoldCommand : ICommand
{
    private Document _document;

    public BoldCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.BoldText();
    }

    public void Undo()
    {
        _document.UnboldText();
    }
    
}