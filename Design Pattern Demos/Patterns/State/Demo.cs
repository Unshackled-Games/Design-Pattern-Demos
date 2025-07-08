namespace Design_Pattern_Demos.Patterns.State;

public interface IState
{
    void Handle(Context context);
}

public class OnState : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Turning off");
        context.State = new OffState();
    }
}

public class OffState : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Turning on");
        context.State = new OnState();
    }
}

public class Context
{
    public IState State { get; set; } = new OffState();
    public void Request() => State.Handle(this);
}

public class Demo
{
    public static void Run()
    {
        var c = new Context();
        c.Request();
        c.Request();
    }
}
