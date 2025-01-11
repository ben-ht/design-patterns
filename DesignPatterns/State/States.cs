namespace DesignPatterns.State;
internal class ReadyState : VendingMachineState
{
    public void HandleRequest()
    {
        Console.WriteLine("Ready state: Please select a product");
    }
}

internal class ProductSelectedState : VendingMachineState 
{
    public void HandleRequest() {
        Console.WriteLine("Product selected state: Processing payment");
    }
}

internal class PaymentPendingState : VendingMachineState
{
    public void HandleRequest()
    {
        Console.WriteLine("Payment pending state: Dispensing product");
    }
}

internal class OutOfStockState : VendingMachineState
{
    public void HandleRequest()
    {
        Console.WriteLine("Out of stock state: Product unvailable. Please select another product.");
    }
}
