namespace Design_Pattern_Demos.Patterns.NullObject;

public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}

public class NullLogger : ILogger
{
    public void Log(string message) { }
}

public class Demo
{
    public static void Run()
    {
        ILogger logger = new NullLogger();
        logger.Log("Nothing happens");
    }
}
