using System.Text;

namespace Design_Pattern_Demos.SOLID.Open_Closed_Principle.Solution;

// New event types can be introduced without modifying the Calendar class

public interface ICalendarEvent
{
    DateTime Date { get; }
    string Description { get; }
    string Export();
}

public class MeetingEvent : ICalendarEvent
{
    public MeetingEvent(DateTime date, string description)
    {
        Date = date;
        Description = description;
    }

    public DateTime Date { get; }
    public string Description { get; }

    public string Export() => $"MEETING: {Date:yyyy-MM-dd HH:mm} - {Description}";
}

public class ReminderEvent : ICalendarEvent
{
    public ReminderEvent(DateTime date, string description)
    {
        Date = date;
        Description = description;
    }

    public DateTime Date { get; }
    public string Description { get; }

    public string Export() => $"REMINDER: {Date:yyyy-MM-dd HH:mm} - {Description}";
}

public class HolidayEvent : ICalendarEvent
{
    public HolidayEvent(DateTime date, string description)
    {
        Date = date;
        Description = description;
    }

    public DateTime Date { get; }
    public string Description { get; }

    public string Export() => $"HOLIDAY: {Date:yyyy-MM-dd} - {Description}";
}

public class Calendar
{
    private readonly List<ICalendarEvent> _events = new();

    public void AddEvent(ICalendarEvent calendarEvent) => _events.Add(calendarEvent);

    // OCP-compliant: no modification needed when adding new event types
    public string Export()
    {
        var sb = new StringBuilder();
        foreach (var e in _events)
            sb.AppendLine(e.Export());
        return sb.ToString();
    }
}