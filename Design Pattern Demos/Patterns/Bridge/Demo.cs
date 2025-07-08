namespace Design_Pattern_Demos.Patterns.Bridge;

public interface IRenderer
{
    string Render(string shape);
}

public class VectorRenderer : IRenderer
{
    public string Render(string shape) => $"Drawing {shape} as vectors";
}

public class RasterRenderer : IRenderer
{
    public string Render(string shape) => $"Drawing {shape} as pixels";
}

public abstract class Shape
{
    protected readonly IRenderer Renderer;
    protected Shape(IRenderer renderer) => Renderer = renderer;
    public abstract string Draw();
}

public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }
    public override string Draw() => Renderer.Render("Circle");
}

public class Demo
{
    public static void Run()
    {
        Shape shape = new Circle(new RasterRenderer());
        Console.WriteLine(shape.Draw());
    }
}
