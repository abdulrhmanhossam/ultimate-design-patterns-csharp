namespace Memento;

class TextEditor
{
    public string Content { get; set; }
    private readonly Stack<string> _prevState;
    private readonly Stack<string> _nextState;

    public TextEditor()
    {
        Content = "";
        _prevState = [];
        _nextState = [];
    }

    public void Save()
    {
        _prevState.Push(Content);
        _nextState.Clear();
    }

    public string Undo()
    {
        if (_prevState is not null)
        {
            _nextState.Push(Content);
            Content = _prevState.Pop();

            return Content;
        }

        return null!;
    }

    public string Redo()
    {
        if (_nextState is not null)
        {
            _prevState.Push(Content);
            Content = _nextState.Pop();
            return Content;
        }

        return null!;
    }
}
