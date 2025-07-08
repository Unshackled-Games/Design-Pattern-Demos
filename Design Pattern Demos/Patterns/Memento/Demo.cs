namespace Design_Pattern_Demos.Patterns.Memento;

public class Memento
{
    public string State { get; }
    public Memento(string state) => State = state;
}

public class Editor
{
    public string Content { get; set; } = "";
    public Memento Save() => new(Content);
    public void Restore(Memento m) => Content = m.State;
}

public class Demo
{
    public static void Run()
    {
        var editor = new Editor();
        editor.Content = "A";
        var m = editor.Save();
        editor.Content = "B";
        editor.Restore(m);
        Console.WriteLine(editor.Content);
    }
}
