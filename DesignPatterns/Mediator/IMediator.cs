namespace DesignPatterns.Mediator;
public interface IMediator
{
    bool NotifyAboutArrival(string trainName);
    void NotifyAboutDeparture(string trainName);
}
