namespace DesignPatterns.State;
internal class VendingMachineContext
{
    private VendingMachineState state;

    public void SetState(VendingMachineState state)
    {
        this.state = state;
    }

    public void Request()
    {
        state.HandleRequest();
    }
}
