namespace Design_Pattern_Demos.SOLID.Dependency_Inversion_Principle.Solution;

// High-level modules depend on the IEventStore abstraction
public interface IEventStore
{
    void SaveEvents(IEnumerable<string> events);
}

public class FileEventStore : IEventStore
{
    private readonly string _fileName;

    public FileEventStore(string fileName)
    {
        _fileName = fileName;
    }

    public void SaveEvents(IEnumerable<string> events)
    {
        File.WriteAllLines(_fileName, events);
    }
}

public class Calendar
{
    private readonly List<string> _events = new();
    private readonly IEventStore _store;

    public Calendar(IEventStore store)
    {
        _store = store;
    }

    public void AddEvent(DateTime date, string description)
    {
        _events.Add($"{date:yyyy-MM-dd}: {description}");
        _store.SaveEvents(_events);
    }
}