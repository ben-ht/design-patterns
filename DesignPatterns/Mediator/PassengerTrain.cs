namespace DesignPatterns.Mediator;

public class PassengerTrain(string name) : ITrain
{
    public string Name { get; set; } = name;

    public void Arrive(IMediator mediator)
    {
        if (!mediator.NotifyAboutArrival(Name))
        {
            Console.WriteLine($"Passenger train {Name}: Arrival blocked, waiting");
            return;
        }

        Console.WriteLine($"Passenger train {Name}: Arrived");
    }

    public void Depart(IMediator mediator)
    {
        Console.WriteLine($"Passenger train {Name}: Leaving");
        mediator.NotifyAboutDeparture(Name);
    }
}
