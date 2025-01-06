namespace DesignPatterns.ChainOfResponsibility;
internal class ValidationHandler : RequestHandlerBase
{
    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine("Validation handler processing request.");
    }
}
