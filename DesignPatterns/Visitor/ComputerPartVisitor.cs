namespace DesignPatterns.Visitor
{
    internal interface ComputerPartVisitor
    {
        void Visit(Keyboard keyboard);
        void Visit(Mouse mouse);
        void Visit(Monitor monitor);
        void Visit(Computer computer);
    }
}
