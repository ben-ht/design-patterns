namespace DesignPatterns.ChainOfResponsibility;
internal interface IRequestHandler
{
    void SetNextHandler(IRequestHandler nextHandler);
    void HandleRequest(Request request);
}
