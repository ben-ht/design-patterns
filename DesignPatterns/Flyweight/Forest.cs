using System.Drawing;

namespace DesignPatterns.FlyWeight;
internal class Forest
{
    private List<Tree> trees;

    public Forest() 
    {
        trees = new List<Tree>();
    }

    public void PlantTree(int x, int y, string name)
    {
        TreeType type = TreeFactory.GetTreeType(name);
        Tree tree = new Tree(x, y, type);
        trees.Add(tree);
    }

    public void Draw()
    {
        foreach (Tree t in trees)
        {
            t.Draw();
        }
    }
}
