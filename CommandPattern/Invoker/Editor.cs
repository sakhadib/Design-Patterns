using CommandPattern.Interfaces;

namespace CommandPattern.Invoker;

public class Editor
{
    private Stack<ICommand> _commandHistory;

    public Editor()
    {
        _commandHistory = new Stack<ICommand>();
    }

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void UndoCommand()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
        else
        {
            Console.WriteLine("No actions to undo.");
        }
    }
}