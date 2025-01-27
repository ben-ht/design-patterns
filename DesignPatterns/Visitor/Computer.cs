namespace DesignPatterns.Visitor
{
    internal class Computer : ComputerPart
    {
        private readonly ComputerPart[] parts;

        public Computer()
        {
            parts = new ComputerPart[] { new Keyboard(), new Mouse(), new Monitor() };
        }

        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].Accept(computerPartVisitor);
            }
            
            computerPartVisitor.Visit(this);
        }
    }
}
