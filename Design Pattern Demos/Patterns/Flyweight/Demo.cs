namespace Design_Pattern_Demos.Patterns.Flyweight;

public class Character
{
    private readonly char _symbol;
    public Character(char c) => _symbol = c;
    public void Draw(int size) => Console.WriteLine($"{_symbol}({size})");
}

public class CharacterFactory
{
    private readonly Dictionary<char, Character> _cache = new();
    public Character Get(char c)
    {
        if (!_cache.TryGetValue(c, out var ch))
        {
            ch = new Character(c);
            _cache[c] = ch;
        }
        return ch;
    }
}

public class Demo
{
    public static void Run()
    {
        var factory = new CharacterFactory();
        var a1 = factory.Get('a');
        var a2 = factory.Get('a');
        Console.WriteLine(object.ReferenceEquals(a1, a2));
    }
}
