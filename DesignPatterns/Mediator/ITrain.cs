namespace DesignPatterns.Mediator;

public interface ITrain
{
    string Name { get; set; }
    void Arrive(IMediator mediator);
    void Depart(IMediator mediator);
}
