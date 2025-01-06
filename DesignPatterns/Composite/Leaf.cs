namespace DesignPatterns.Composite;
internal class Leaf : IComponent
{

    public void Add(IComponent component)
    {
        throw new NotImplementedException();
    }

    public void Remove(IComponent component)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Leaf";
    }
            
}
