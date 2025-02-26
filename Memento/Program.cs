using Memento;

class Program 
{
    static void Main()
    {
        TextEditor textEditor = new TextEditor();

        textEditor.Content = "Hello, ";
        textEditor.Save();

        textEditor.Content = "World!";
        textEditor.Save();

        textEditor.Content = "Welcome to Design Pattern Course!";
        textEditor.Undo();
        textEditor.Undo();
        textEditor.Redo();

        Console.WriteLine(textEditor.Content);
    }
}
