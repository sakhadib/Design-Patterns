namespace CommandPattern.Core;

public class Document
{
    public string Text { get; set; }
    public bool IsBold { get; set; }

    public void AddText(string text)
    {
        Text += text;
        Console.WriteLine($"Added text: {Text}");
    }

    public void BoldText()
    {
        IsBold = true;
        Console.WriteLine("Text has been bolded.");
    }

    public void UnboldText()
    {
        IsBold = false;
        Console.WriteLine("Text has been unbolded.");
    }
}