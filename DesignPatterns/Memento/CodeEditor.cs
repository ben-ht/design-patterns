namespace DesignPatterns.Memento;
internal class CodeEditor
{
    public string Content { get; set; }

    public CodeEditorState CreateState()
    {
        return new CodeEditorState(Content);
    }

    public void Restore(CodeEditorState state)
    {
        Content = state.Content;
    }
}
