namespace DesignPatterns.ChainOfResponsibility;
internal abstract class RequestHandlerBase : IRequestHandler
{
    private IRequestHandler? nextHandler;

    public void SetNextHandler(IRequestHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public virtual void HandleRequest(Request request)
    {
        ProcessRequest(request);
        nextHandler?.HandleRequest(request);
    }

    protected abstract void ProcessRequest(Request request);
}
