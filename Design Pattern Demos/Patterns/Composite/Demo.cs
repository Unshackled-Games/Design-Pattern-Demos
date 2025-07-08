namespace Design_Pattern_Demos.Patterns.Composite;

public interface IGraphic
{
    void Draw();
}

public class Dot : IGraphic
{
    public void Draw() => Console.WriteLine("Dot");
}

public class GraphicGroup : IGraphic
{
    private readonly List<IGraphic> _children = new();
    public void Add(IGraphic g) => _children.Add(g);
    public void Draw()
    {
        foreach (var c in _children) c.Draw();
    }
}

public class Demo
{
    public static void Run()
    {
        var group = new GraphicGroup();
        group.Add(new Dot());
        group.Add(new Dot());
        group.Draw();
    }
}
