namespace DesignPatterns.Adapter;
internal class TabletCharger : ICharger
{
    public void Charge()
    {
        Console.WriteLine("Charging with a tablet charger");
    }
}
