namespace Design_Pattern_Demos.SOLID.Interface_Segregation_Principle.Solution;

// Small focused interfaces
public interface IEventManager
{
    void AddEvent(DateTime date, string description);
    void RemoveEvent(int index);
}

public interface IPersistable
{
    void Save(string fileName);
    void Load(string fileName);
}

public interface ICloudSync
{
    void SyncWithCloud();
}

public interface IPrintable
{
    void Print();
}

// Desktop calendar only implements what it actually needs
public class DesktopCalendar : IEventManager, IPrintable
{
    private readonly List<string> _events = new();

    public void AddEvent(DateTime date, string description)
        => _events.Add($"{date:yyyy-MM-dd}: {description}");

    public void RemoveEvent(int index)
    {
        if (index >= 0 && index < _events.Count)
            _events.RemoveAt(index);
    }

    public void Print()
    {
        Console.WriteLine("Desktop calendar events:");
        foreach (var e in _events)
            Console.WriteLine(e);
    }
}

// Cloud calendar supports all features
public class CloudCalendar : IEventManager, IPersistable, ICloudSync, IPrintable
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