namespace Design_Pattern_Demos.SOLID.Single_Responsibility.Problem;

// Responsibility #1: Tracking calendar data
// Responsibility #2: Saving to disk
// Responsibility #3: Printing to console

public class Calendar
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
    
    public void Save(string fileName)
    {
        // Any change in storage (database, cloud, etc.) forces changes here
        File.WriteAllLines(fileName, _events);
    }

    public void Load(string fileName)
    {
        if (!File.Exists(fileName)) return;
        _events.Clear();
        _events.AddRange(File.ReadAllLines(fileName));
    }

    public void Print()
    {
        // Presentation logic intertwined with data management
        Console.WriteLine("Calendar events:");
        Console.WriteLine(string.Join(Environment.NewLine, _events));
    }
}