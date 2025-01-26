using System.Drawing;

namespace DesignPatterns.FlyWeight;
internal class TreeType
{
    private string name;

    public TreeType(string name)
    {
        this.name = name;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine("Drawing a tree");
    }
}
