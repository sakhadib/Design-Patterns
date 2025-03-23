using CommandPattern.Commands;
using CommandPattern.Core;
using CommandPattern.Interfaces;
using CommandPattern.Invoker;

class main
{
    public static void Main(string[] args)
    {
        // Create a document to edit
        Document doc = new Document();

        // Create the editor that will execute commands
        Editor editor = new Editor();

        // Add text and bold it
        ICommand addText = new AddTextCommand(doc, "Hello, World!");
        editor.ExecuteCommand(addText);

        ICommand boldText = new BoldCommand(doc);
        editor.ExecuteCommand(boldText);

        // Undo the bold operation
        editor.UndoCommand();

        // Add more text and bold it again
        ICommand addText2 = new AddTextCommand(doc, " Welcome to CQRS!");
        editor.ExecuteCommand(addText2);
        ICommand boldText2 = new BoldCommand(doc);
        editor.ExecuteCommand(boldText2);

        // Undo all actions
        editor.UndoCommand();
        editor.UndoCommand();
        editor.UndoCommand(); // This will remove the last added text
        editor.UndoCommand(); // This will remove the previous text
    }
}