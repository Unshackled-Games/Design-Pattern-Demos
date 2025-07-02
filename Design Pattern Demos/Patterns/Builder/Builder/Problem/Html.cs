using System.Text;
using static System.Console;

namespace Design_Pattern_Demos.Patterns.Builder.Builder.Problem;

public class Html
{
    public void Demo()
    {
        var hello = "hello";
        var sb = new StringBuilder();
        sb.Append("<p>");
        sb.Append(hello);
        sb.Append("</p>");
        WriteLine(sb);
        
        var words = new[] {"hello", "world"};
        sb.Clear();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.AppendFormat("<li>{0}</li>", word);
        }
        sb.Append("</ul>");
        WriteLine(sb);      
        sb.Clear();
    }
}