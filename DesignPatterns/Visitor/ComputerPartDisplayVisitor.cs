namespace DesignPatterns.Visitor
{
    internal class ComputerPartDisplayVisitor : ComputerPartVisitor
    {
        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying keyboard");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying mouse");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying monitor");
        }

        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying computer");
        }
    }
}
