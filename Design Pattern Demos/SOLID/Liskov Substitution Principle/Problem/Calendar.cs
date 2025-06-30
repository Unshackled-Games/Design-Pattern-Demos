namespace Design_Pattern_Demos.SOLID.Liskov_Substitution_Principle.Problem;

// Base calendar allowing events to be added or removed
public class Calendar
{
    protected readonly List<string> _events = new();

    public virtual void AddEvent(DateTime date, string description)
    {
        _events.Add($"{date:yyyy-MM-dd}: {description}");
    }

    public virtual void RemoveEvent(int index)
    {
        if (index >= 0 && index < _events.Count)
            _events.RemoveAt(index);
    }

    public IReadOnlyList<string> Events => _events.AsReadOnly();
}

// This derived calendar breaks LSP by prohibiting modification
public class ReadOnlyCalendar : Calendar
{
    public override void AddEvent(DateTime date, string description)
    {
        throw new InvalidOperationException("Calendar is read-only.");
    }

    public override void RemoveEvent(int index)
    {
        throw new InvalidOperationException("Calendar is read-only.");
    }
}

// Client expecting a modifiable Calendar
public class EventScheduler
{
    private readonly Calendar _calendar;

    public EventScheduler(Calendar calendar)
    {
        _calendar = calendar;
    }

    public void ScheduleEvent(DateTime date, string description)
    {
        // Works for Calendar but fails for ReadOnlyCalendar
        _calendar.AddEvent(date, description);
    }
}