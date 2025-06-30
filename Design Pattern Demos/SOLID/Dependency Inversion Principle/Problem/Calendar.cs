namespace Design_Pattern_Demos.SOLID.Dependency_Inversion_Principle.Problem;

// High-level Calendar class directly depends on a concrete FileEventStore
// Changing storage (e.g., database, cloud) requires modifying Calendar

public class FileEventStore
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
    private readonly FileEventStore _store;

    public Calendar(string fileName)
    {
        // Direct dependency on a concrete storage implementation
        _store = new FileEventStore(fileName);
    }

    public void AddEvent(DateTime date, string description)
    {
        _events.Add($"{date:yyyy-MM-dd}: {description}");
        // Persistence is tightly coupled to the calendar logic
        _store.SaveEvents(_events);
    }
}