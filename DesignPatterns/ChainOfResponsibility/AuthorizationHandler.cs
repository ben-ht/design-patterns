namespace DesignPatterns.ChainOfResponsibility;
internal class AuthorizationHandler : RequestHandlerBase
{
    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine("Authorization handler processing request.");
    }
}
