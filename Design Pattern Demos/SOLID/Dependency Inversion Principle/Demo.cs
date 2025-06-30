using Design_Pattern_Demos.SOLID.Dependency_Inversion_Principle.Solution;

namespace Design_Pattern_Demos.SOLID.Dependency_Inversion_Principle;

public class Demo {
    private class InMemoryEventStore : IEventStore
    {
        public List<string> Events { get; } = new();
        public void SaveEvents(IEnumerable<string> events)
        {
            Events.Clear();
            Events.AddRange(events);
        }
    }

    public static void Run()
    {
        Console.WriteLine("--- DIP violation example ---");
        var problemCalendar = new Problem.Calendar("dip-problem.txt");
        problemCalendar.AddEvent(DateTime.Today, "Direct file dependency");
        Console.WriteLine(File.ReadAllText("dip-problem.txt"));

        Console.WriteLine("--- DIP solution example ---");
        var store = new InMemoryEventStore();
        var solutionCalendar = new Solution.Calendar(store);
        solutionCalendar.AddEvent(DateTime.Today, "Inversion principle");
        Console.WriteLine(string.Join(Environment.NewLine, store.Events));
    }
}