using System.Collections;

namespace DesignPatterns.Iterator;
internal class FruitList : IEnumerable<string>
{
    private readonly List<string> list = [];

    public void AddFruit(string fruit)
    {
        list.Add(fruit);
    }


    public IEnumerator<string> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list.GetEnumerator();
    }
}
