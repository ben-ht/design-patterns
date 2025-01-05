namespace DesignPatterns.Observer;
internal class Subject
{
    private readonly List<IObserver> observers = [];
    private int number;

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            NotifyAllObservers();
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyAllObservers()
    {
        foreach(IObserver observer in observers) 
        {
            observer.Update();
        }
    }
}
