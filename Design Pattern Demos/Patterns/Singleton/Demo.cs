namespace Design_Pattern_Demos.Patterns.Singleton;

public sealed class SimpleSingleton
{
    private static readonly SimpleSingleton _instance = new SimpleSingleton();
    public static SimpleSingleton Instance => _instance;
    private SimpleSingleton() { }
    public string SayHello() => "Hello";
}

public class Demo
{
    public static void Run()
    {
        Console.WriteLine(SimpleSingleton.Instance.SayHello());
    }
}
