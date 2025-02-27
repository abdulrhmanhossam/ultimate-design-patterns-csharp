using Memento;

class Program 
{
    static void Main()
    {
        TextEditor textEditor = new TextEditor();
        History history = new History();

        textEditor.Content = "Hello, ";
        history.SaveHistoryState(textEditor.Save());

        textEditor.Content = "World!";
        history.SaveHistoryState(textEditor.Save());

        textEditor.Content = "Welcome to Design Pattern Course!";
        history.SaveHistoryState(textEditor.Save());

        textEditor.Content = "This should not be printed";
        textEditor.Restore(history.Undo());
        textEditor.Restore(history.Undo());

        Console.WriteLine(textEditor.Content);
    }
}
