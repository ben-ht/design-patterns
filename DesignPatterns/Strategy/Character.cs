namespace DesignPatterns.Strategy;
internal class Character
{
    private const int BASE_DAMAGE = 10;

    private readonly string name;
    private readonly IWeapon weapon;

    public Character(string name, IWeapon weapon)
    {
        this.name = name;
        this.weapon = weapon;
    }

    public void Attack()
    {
        Console.WriteLine($"{name} attacks with a {weapon.GetName()} and deals {weapon.Attack(BASE_DAMAGE)} damage.");
    }

}
