using CommandPattern.Core;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class UnBoldCommand : ICommand
{
    private Document _document;

    public UnBoldCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.UnboldText();
    }

    public void Undo()
    {
        _document.BoldText();
    }
}