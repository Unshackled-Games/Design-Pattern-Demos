namespace Design_Pattern_Demos.Patterns.Proxy;

public interface IImage
{
    void Display();
}

public class RealImage : IImage
{
    private readonly string _filename;
    public RealImage(string filename) => _filename = filename;
    public void Display() => Console.WriteLine($"Displaying {_filename}");
}

public class LazyImage : IImage
{
    private readonly string _filename;
    private RealImage? _real;
    public LazyImage(string filename) => _filename = filename;
    public void Display()
    {
        _real ??= new RealImage(_filename);
        _real.Display();
    }
}

public class Demo
{
    public static void Run()
    {
        IImage img = new LazyImage("cat.png");
        img.Display();
        img.Display();
    }
}
