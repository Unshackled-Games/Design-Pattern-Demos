namespace Design_Pattern_Demos.Patterns.Visitor;

public interface IVisitor
{
    void Visit(NumberElement e);
}

public class PrintVisitor : IVisitor
{
    public void Visit(NumberElement e) => Console.WriteLine(e.Number);
}

public interface IElement
{
    void Accept(IVisitor visitor);
}

public class NumberElement : IElement
{
    public int Number { get; }
    public NumberElement(int number) => Number = number;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}

public class Demo
{
    public static void Run()
    {
        IElement element = new NumberElement(5);
        element.Accept(new PrintVisitor());
    }
}
