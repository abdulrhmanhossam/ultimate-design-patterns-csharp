namespace Memento;

class TextEditor
{
    public string Content { get; set; }

    public TextEditor()
    {
        Content = "";
    }

    public TextEditorState Save()
    {
        return new TextEditorState(Content);
    }

    public void Restore(TextEditorState textEditorState)
    {
        Content = textEditorState.Content;
    }
}
