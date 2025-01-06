using System.Text;

namespace DesignPatterns.Composite;
internal class Branch : IComponent
{
    protected List<IComponent> branches = [];

    public void Add(IComponent component)
    {
        branches.Add(component);
    }

    public void Remove(IComponent component)
    {
        branches.Remove(component);
    }

    public override string ToString()
    {
        StringBuilder s = new StringBuilder("Branch(");
        int i = 0;
        foreach (IComponent component in branches)
        {
            s.Append(component);
            if (i != branches.Count - 1) { 
                s.Append('+');
            }

            i++;
        }

        s.Append(')');
        return s.ToString();
    }
}
