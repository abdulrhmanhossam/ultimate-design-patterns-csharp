namespace Memento;

class History
{
    private readonly Stack<TextEditorState> _prevState;

    public History()
    {
        _prevState = [];
    }

    public void SaveHistoryState(TextEditorState textEditorState)
    {
        _prevState.Push(textEditorState);
    }

    public TextEditorState Undo()
    {
        if (_prevState is not null)
            return _prevState.Pop();
        return null!;
    }
}
