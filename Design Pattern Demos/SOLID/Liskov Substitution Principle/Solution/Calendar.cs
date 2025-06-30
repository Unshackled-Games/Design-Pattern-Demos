namespace Design_Pattern_Demos.SOLID.Liskov_Substitution_Principle.Solution;

// Interfaces segregating read-only and editable behaviors
public interface ICalendar
{
    IReadOnlyList<string> Events { get; }
}

public interface IEditableCalendar : ICalendar
{
    void AddEvent(DateTime date, string description);
    void RemoveEvent(int index);
}

// Regular calendar that supports modification
public class Calendar : IEditableCalendar
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
}

// Read-only calendar exposing events but no modification methods
public class ReadOnlyCalendar : ICalendar
{
    private readonly ICalendar _calendar;

    public ReadOnlyCalendar(ICalendar calendar)
    {
        _calendar = calendar;
    }

    public IReadOnlyList<string> Events => _calendar.Events;
}

// Client that explicitly requires an editable calendar
public class EventScheduler
{
    private readonly IEditableCalendar _calendar;

    public EventScheduler(IEditableCalendar calendar)
    {
        _calendar = calendar;
    }

    public void ScheduleEvent(DateTime date, string description)
    {
        _calendar.AddEvent(date, description);
    }
}