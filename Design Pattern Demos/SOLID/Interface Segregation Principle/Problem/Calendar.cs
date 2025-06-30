namespace Design_Pattern_Demos.SOLID.Interface_Segregation_Principle.Problem;


// Single fat interface containing unrelated operations
public interface ICalendar
{
    void AddEvent(DateTime date, string description);
    void RemoveEvent(int index);

    // Persistence operations
    void Save(string fileName);
    void Load(string fileName);

    // Synchronization operation
    void SyncWithCloud();

    // Presentation operation
    void Print();
}

// A simple desktop calendar only cares about managing and printing events,
// but it must implement every method from ICalendar
public class DesktopCalendar : ICalendar
{
    private readonly List<string> _events = new();

    public void AddEvent(DateTime date, string description)
        => _events.Add($"{date:yyyy-MM-dd}: {description}");

    public void RemoveEvent(int index)
    {
        if (index >= 0 && index < _events.Count)
            _events.RemoveAt(index);
    }

    // These operations are irrelevant for the desktop version
    public void Save(string fileName)
        => throw new NotImplementedException();

    public void Load(string fileName)
        => throw new NotImplementedException();

    public void SyncWithCloud()
        => throw new NotImplementedException();

    public void Print()
    {
        Console.WriteLine("Desktop calendar events:");
        foreach (var e in _events)
            Console.WriteLine(e);
    }
}

// A cloud calendar provides all features
public class CloudCalendar : ICalendar
{
    private readonly List<string> _events = new();

    public void AddEvent(DateTime date, string description)
        => _events.Add($"{date:yyyy-MM-dd}: {description}");

    public void RemoveEvent(int index)
    {
        if (index >= 0 && index < _events.Count)
            _events.RemoveAt(index);
    }

    public void Save(string fileName)
        => File.WriteAllLines(fileName, _events);

    public void Load(string fileName)
    {
        if (!File.Exists(fileName)) return;
        _events.Clear();
        _events.AddRange(File.ReadAllLines(fileName));
    }

    public void SyncWithCloud()
    {
        // Imagine complex cloud synchronization here
        Console.WriteLine("Calendar synchronized with cloud.");
    }

    public void Print()
    {
        Console.WriteLine("Cloud calendar events:");
        foreach (var e in _events)
            Console.WriteLine(e);
    }
}