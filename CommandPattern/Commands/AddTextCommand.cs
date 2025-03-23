using CommandPattern.Core;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class AddTextCommand : ICommand
{
    private Document _document;
    private string _text;

    public AddTextCommand(Document document, string text)
    {
        _document = document;
        _text = text;
    }

    public void Execute()
    {
        _document.AddText(_text);
    }

    public void Undo()
    {
        // Remove the text added (simplification, in reality, you'd likely handle this more carefully)
        _document.Text = _document.Text.Substring(0, _document.Text.Length - _text.Length);
        Console.WriteLine($"Undone text addition. Current text: {_document.Text}");
    }
    
}