namespace DesignPatterns.Adapter;
internal class SamsungPhone : IDevice
{
    private readonly ChargerAdapter phoneAdapter;

    public SamsungPhone(ChargerAdapter phoneAdapter)
    {
        this.phoneAdapter = phoneAdapter;
    }

    public void OnCharge()
    {
        phoneAdapter.Charge();
    }
}
