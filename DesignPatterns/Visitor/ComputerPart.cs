namespace DesignPatterns.Visitor
{
    internal interface ComputerPart
    {
        void Accept(ComputerPartVisitor computerPartVisitor);
    }
}
