using System.Text;
using static System.Console;

namespace Design_Pattern_Demos.Patterns.Builder.Builder.Solution;
class HtmlElement
{
    public string Name, Text;
    public readonly List<HtmlElement> Elements = new List<HtmlElement>();
    private const int IndentSize = 2;

    public HtmlElement() { }

    public HtmlElement(string name, string text)
    {
        Name = name;
        Text = text;
    }

    private string ToStringImpl(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', IndentSize * indent);
        sb.Append($"{i}<{Name}>\n");
        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', IndentSize * (indent + 1)));
            sb.Append(Text);
            sb.Append("\n");
        }

        foreach (var e in Elements)
            sb.Append(e.ToStringImpl(indent + 1));

        sb.Append($"{i}</{Name}>\n");
        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }
}

class HtmlBuilder
{
    private readonly string _rootName;

    public HtmlBuilder(string rootName)
    {
        this._rootName = rootName;
        _root.Name = rootName;
    }

    // not fluent
    public void AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);
    }

    public HtmlBuilder AddChildFluent(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);
        return this;
    }

    public override string ToString()
    {
        return _root.ToString();
    }

    public void Clear()
    {
        _root = new HtmlElement{Name = _rootName};
    }

    private HtmlElement _root = new HtmlElement();
}

public class Html
{
    public void Demo()
    {
        // ordinary non-fluent builder
        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello");
        builder.AddChild("li", "world");
        WriteLine(builder.ToString());

        // fluent builder
        builder.Clear(); // disengage builder from the object it's building, then...
        builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
        WriteLine(builder);
    }
}