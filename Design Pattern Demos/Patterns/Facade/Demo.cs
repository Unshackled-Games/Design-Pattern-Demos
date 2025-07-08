namespace Design_Pattern_Demos.Patterns.Facade;

class Cpu { public void Freeze(){} public void Execute(){ Console.WriteLine("Run"); } }
class Memory { public void Load(){} }
class ComputerFacade
{
    private readonly Cpu _cpu = new();
    private readonly Memory _memory = new();
    public void Start()
    {
        _cpu.Freeze();
        _memory.Load();
        _cpu.Execute();
    }
}

public class Demo
{
    public static void Run()
    {
        var computer = new ComputerFacade();
        computer.Start();
    }
}
