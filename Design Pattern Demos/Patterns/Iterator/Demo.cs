namespace Design_Pattern_Demos.Patterns.Iterator;

public class NumberCollection : IEnumerable<int>
{
    private readonly int[] _numbers = {1,2,3};
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < _numbers.Length; i++)
            yield return _numbers[i];
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Demo
{
    public static void Run()
    {
        var collection = new NumberCollection();
        foreach (var n in collection)
            Console.Write(n);
    }
}
