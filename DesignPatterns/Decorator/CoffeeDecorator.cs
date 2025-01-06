namespace DesignPatterns.Decorator;
internal abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public abstract void MakeCoffee();
}
