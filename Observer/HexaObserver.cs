namespace DesignPatterns.Observer;
internal class HexaObserver : IObserver
{
    private readonly Subject subject;

    public HexaObserver(Subject subject)
    {
        this.subject = subject;
    }

    public void Update()
    {
        Console.WriteLine($"Hexadecimal: {subject.Number:X}");
    }
}
