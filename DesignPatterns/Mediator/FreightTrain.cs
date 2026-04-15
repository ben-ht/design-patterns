namespace DesignPatterns.Mediator;

public class FreightTrain(string name) : ITrain
{
    public string Name { get; set; } = name;

    public void Arrive(IMediator mediator)
    {
        if (!mediator.NotifyAboutArrival(Name))
        {
            Console.WriteLine($"Freight train {Name}: Arrival blocked, waiting");
            return;
        }

        Console.WriteLine($"Freight train {Name}: Arrived");
    }

    public void Depart(IMediator mediator)
    {
        Console.WriteLine($"Freight train {Name}: Leaving");
        mediator.NotifyAboutDeparture(Name);
    }
}
