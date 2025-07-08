namespace Design_Pattern_Demos.Patterns.Factory;

public interface IShape
{
    string Draw();
}

public class Circle : IShape
{
    public string Draw() => "Circle";
}

public class Square : IShape
{
    public string Draw() => "Square";
}

public static class ShapeFactory
{
    public static IShape Create(string type) => type switch
    {
        "circle" => new Circle(),
        "square" => new Square(),
        _ => throw new ArgumentException("Unknown shape")
    };
}

public class Demo
{
    public static void Run()
    {
        var shape = ShapeFactory.Create("circle");
        Console.WriteLine(shape.Draw());
    }
}
