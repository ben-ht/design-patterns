namespace DesignPatterns.Strategy;
internal class Bow : IWeapon
{
    public int Attack(int damage)
    {
        return (int)(damage * 1.2);
    }

    public string GetName()
    {
        return "bow";
    }
}
