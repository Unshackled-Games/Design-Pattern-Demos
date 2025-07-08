namespace Design_Pattern_Demos.Patterns.Interpreter;

public interface IExpression
{
    int Interpret();
}

public class Number : IExpression
{
    private readonly int _value;
    public Number(int value) => _value = value;
    public int Interpret() => _value;
}

public class Add : IExpression
{
    private readonly IExpression _left, _right;
    public Add(IExpression left, IExpression right)
    {
        _left = left; _right = right;
    }
    public int Interpret() => _left.Interpret() + _right.Interpret();
}

public class Demo
{
    public static void Run()
    {
        IExpression expr = new Add(new Number(1), new Number(2));
        Console.WriteLine(expr.Interpret());
    }
}
