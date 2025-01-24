namespace DesignPatterns.Memento;
internal class CodeEditorState
{
    public string Content { get; }

    public CodeEditorState(string content)
    {
        Content = content;
    }
}
