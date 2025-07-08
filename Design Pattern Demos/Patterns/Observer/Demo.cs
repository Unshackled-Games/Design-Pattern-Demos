namespace Design_Pattern_Demos.Patterns.Observer;

public class Subject
{
    public event Action? Changed;
    public void Notify() => Changed?.Invoke();
}

public class Observer
{
    public Observer(Subject s) => s.Changed += () => Console.WriteLine("Observed");
}

public class Demo
{
    public static void Run()
    {
        var subject = new Subject();
        var obs = new Observer(subject);
        subject.Notify();
    }
}
