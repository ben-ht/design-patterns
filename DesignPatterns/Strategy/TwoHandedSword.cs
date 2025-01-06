namespace DesignPatterns.Strategy;
internal class TwoHandedSword : IWeapon
{
    public int Attack(int damage)
    {
        return damage * 2;
    }

    public string GetName()
    {
        return "two handed sword";
    }
}
