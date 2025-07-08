namespace Design_Pattern_Demos.Patterns.TemplateMethod;

public abstract class Game
{
    public void Play()
    {
        Start();
        End();
    }
    protected abstract void Start();
    protected abstract void End();
}

public class Chess : Game
{
    protected override void Start() => Console.WriteLine("Chess start");
    protected override void End() => Console.WriteLine("Chess end");
}

public class Demo
{
    public static void Run()
    {
        Game game = new Chess();
        game.Play();
    }
}
