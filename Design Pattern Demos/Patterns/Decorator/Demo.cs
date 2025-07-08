namespace Design_Pattern_Demos.Patterns.Decorator;

public interface IMessage
{
    string GetContent();
}

public class TextMessage : IMessage
{
    private readonly string _text;
    public TextMessage(string text) => _text = text;
    public string GetContent() => _text;
}

public class TimestampDecorator : IMessage
{
    private readonly IMessage _inner;
    public TimestampDecorator(IMessage inner) => _inner = inner;
    public string GetContent() => $"[{DateTime.Now}] {_inner.GetContent()}";
}

public class Demo
{
    public static void Run()
    {
        IMessage msg = new TimestampDecorator(new TextMessage("Hello"));
        Console.WriteLine(msg.GetContent());
    }
}
