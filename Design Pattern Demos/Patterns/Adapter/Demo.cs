namespace Design_Pattern_Demos.Patterns.Adapter;

public interface ITarget
{
    string Request();
}

public class Adaptee
{
    public string SpecificRequest() => "Adaptee";
}

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;
    public Adapter(Adaptee adaptee) => _adaptee = adaptee;
    public string Request() => _adaptee.SpecificRequest();
}

public class Demo
{
    public static void Run()
    {
        ITarget target = new Adapter(new Adaptee());
        Console.WriteLine(target.Request());
    }
}
