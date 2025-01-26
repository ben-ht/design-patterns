namespace DesignPatterns.FlyWeight;
internal static class TreeFactory
{
    private static readonly Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

    public static TreeType GetTreeType(string name)
    {
        treeTypes.TryGetValue(name, out TreeType? result);
        if (result == null)
        {
            result = new TreeType(name);
            treeTypes.Add(name, result);
        }

        return result;
    }
}
