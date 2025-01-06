namespace DesignPatterns.Observer;
internal class BinaryOberver : IObserver
{
    private readonly Subject subject;

    public BinaryOberver(Subject subject)
    {
        this.subject = subject;
    }

    public void Update()
    {
        Console.WriteLine($"Binary: {Convert.ToString(subject.Number, 2)}");
    }
}
