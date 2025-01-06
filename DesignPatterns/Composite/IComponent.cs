namespace DesignPatterns.Composite;
internal interface IComponent
{
    public void Add(IComponent component);
    public void Remove(IComponent component);
}
