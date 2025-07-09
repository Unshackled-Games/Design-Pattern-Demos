namespace Design_Pattern_Demos.Patterns.Adapter;

public interface ILogger
{
    void Log(string message);
}

public class LegacyLogger
{
    public void WriteMessage(string msg) => Console.WriteLine($"Legacy: {msg}");
}

public class LoggerAdapter : ILogger
{
    private readonly LegacyLogger _legacy;
    public LoggerAdapter(LegacyLogger legacy) => _legacy = legacy;
    public void Log(string message) => _legacy.WriteMessage(message);
}

public class Demo
{
    public static void Run()
    {
        ILogger logger = new LoggerAdapter(new LegacyLogger());
        logger.Log("Adapter pattern in action");
    }
}
