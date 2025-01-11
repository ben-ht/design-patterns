namespace DesignPatterns.Bridge;
internal class AdvancedRemote : BaseRemote
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public void Mute()
    {
        Console.WriteLine("Remote: mute");
        device.SetVolume(0);
    }
}
