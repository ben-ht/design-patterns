namespace DesignPatterns.Strategy;
internal interface IWeapon
{
    int Attack(int damage);

    string GetName();
}
