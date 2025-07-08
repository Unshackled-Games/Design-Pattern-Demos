namespace Design_Pattern_Demos.Patterns.ChainOfResponsibility;

public abstract class Handler
{
    protected Handler? Next;
    public Handler SetNext(Handler next) { Next = next; return next; }
    public abstract void Handle(int number);
}

public class OddHandler : Handler
{
    public override void Handle(int number)
    {
        if (number % 2 == 1) Console.WriteLine($"Odd: {number}");
        else Next?.Handle(number);
    }
}

public class EvenHandler : Handler
{
    public override void Handle(int number)
    {
        if (number % 2 == 0) Console.WriteLine($"Even: {number}");
        else Next?.Handle(number);
    }
}

public class Demo
{
    public static void Run()
    {
        var odd = new OddHandler();
        var even = new EvenHandler();
        odd.SetNext(even);
        odd.Handle(3);
        odd.Handle(2);
    }
}
