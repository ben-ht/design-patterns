namespace DesignPatterns.Memento;
internal class History
{
    private readonly List<CodeEditorState> states;

    public History() 
    {
        states = new List<CodeEditorState>();
    }

    public void Push(CodeEditorState state)
    {
        states.Add(state);
    }

    public CodeEditorState Pop()
    {
        CodeEditorState state = states[^1];
        states.Remove(state);
        return state;
    }

    public CodeEditorState At(int index)
    {
        states.RemoveRange(index + 1, states.Count - 2);
        return states[index];
    }


}
