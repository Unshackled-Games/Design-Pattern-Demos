namespace Design_Pattern_Demos.Patterns.Strategy;

public interface ISortStrategy
{
    void Sort(List<int> list);
}

public class BubbleSort : ISortStrategy
{
    public void Sort(List<int> list) => Console.WriteLine("BubbleSort");
}

public class QuickSort : ISortStrategy
{
    public void Sort(List<int> list) => Console.WriteLine("QuickSort");
}

public class Sorter
{
    private ISortStrategy _strategy;
    public Sorter(ISortStrategy strategy) => _strategy = strategy;
    public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;
    public void Sort(List<int> list) => _strategy.Sort(list);
}

public class Demo
{
    public static void Run()
    {
        var sorter = new Sorter(new BubbleSort());
        sorter.Sort(new List<int>());
        sorter.SetStrategy(new QuickSort());
        sorter.Sort(new List<int>());
    }
}
