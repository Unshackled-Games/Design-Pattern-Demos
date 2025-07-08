namespace Design_Pattern_Demos.Patterns.Command;

public interface ICommand
{
    void Execute();
}

public class Light
{
    public void On() => Console.WriteLine("Light on");
}

public class LightOnCommand : ICommand
{
    private readonly Light _light;
    public LightOnCommand(Light light) => _light = light;
    public void Execute() => _light.On();
}

public class Remote
{
    public ICommand? Command { get; set; }
    public void Press() => Command?.Execute();
}

public class Demo
{
    public static void Run()
    {
        var remote = new Remote { Command = new LightOnCommand(new Light()) };
        remote.Press();
    }
}
