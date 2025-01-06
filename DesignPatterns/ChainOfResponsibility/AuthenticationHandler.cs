namespace DesignPatterns.ChainOfResponsibility;
internal class AuthenticationHandler : RequestHandlerBase
{
    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine("Authentication handler processing request.");
    }
}
