namespace Design_Pattern_Demos.SOLID.Single_Responsibility.Solution;

// SRP-compliant implementation using separate classes
public class EventCalendar
{
    private readonly List<string> _events = new();

    public void AddEvent(DateTime date, string description)
    {
        _events.Add($"{date:yyyy-MM-dd}: {description}");
    }

    public void RemoveEvent(int index)
    {
        if (index >= 0 && index < _events.Count)
            _events.RemoveAt(index);
    }

    public IReadOnlyList<string> Events => _events.AsReadOnly();

    public void Clear() => _events.Clear();
}

public class CalendarPersistence
{
    public void Save(EventCalendar calendar, string fileName)
    {
        File.WriteAllLines(fileName, calendar.Events);
    }

    public void Load(EventCalendar calendar, string fileName)
    {
        if (!File.Exists(fileName)) return;
        calendar.Clear();
        foreach (var line in File.ReadAllLines(fileName))
            calendar.AddEvent(DateTime.Parse(line.Split(':')[0]), line[(line.IndexOf(':') + 2)..]);
    }
}

public class CalendarPrinter
{
    public void Print(EventCalendar calendar)
    {
        Console.WriteLine("Calendar events:");
        foreach (var e in calendar.Events)
            Console.WriteLine(e);
    }
}