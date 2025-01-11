using System.Text;

namespace DesignPatterns.Bridge;
internal class Radio : IDevice
{
    private bool on = false;
    private int volume = 30;
    private int channel = 1;

    public void Disable()
    {
        on = false;
    }

    public void Enable()
    {
        on = true;
    }

    public int GetChannel()
    {
        return channel;
    }

    public int GetVolume()
    {
        return volume;
    }

    public bool IsEnabled()
    {
        return on;
    }

    public void SetChannel(int channel)
    {
        this.channel = channel;
    }

    public void SetVolume(int volume)
    {
        if (volume > 100)
        {
            this.volume = 100;
        } else if (volume < 0)
        {
            this.volume = 0;
        }
        else
        {
            this.volume = volume;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Radio");
        sb.AppendLine($"Status: {(on ? "enabled" : "disabled")}");
        sb.AppendLine($"Volume: {volume}%");
        sb.AppendLine($"Channel: {channel}");
        return sb.ToString();
    }
}
