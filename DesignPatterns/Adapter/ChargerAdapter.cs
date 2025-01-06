namespace DesignPatterns.Adapter;
internal class ChargerAdapter : ICharger
{
    private readonly TabletCharger tabletCharger;

    public ChargerAdapter()
    {
        tabletCharger = new TabletCharger();
    }

    public void Charge()
    {
        tabletCharger.Charge();
    }
}
