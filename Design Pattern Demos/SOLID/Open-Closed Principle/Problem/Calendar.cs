using System.Text;

namespace Design_Pattern_Demos.SOLID.Open_Closed_Principle.Problem;

// Adding new event types requires modifying the Calendar class
public enum EventType
{
    Meeting,
    Reminder,
    Holiday
}

public class CalendarEvent
{
    public CalendarEvent(DateTime date, string description, EventType type)
    {
        Date = date;
        Description = description;
        Type = type;
    }

    public DateTime Date { get; }
    public string Description { get; }
    public EventType Type { get; }
}

public class Calendar
{
    private readonly List<CalendarEvent> _events = new();

    public void AddEvent(CalendarEvent calendarEvent) => _events.Add(calendarEvent);

    // This method breaks OCP: it must change whenever a new EventType is introduced
    public string Export()
    {
        var sb = new StringBuilder();
        foreach (var e in _events)
        {
            switch (e.Type)
            {
                case EventType.Meeting:
                    sb.AppendLine($"MEETING: {e.Date:yyyy-MM-dd HH:mm} - {e.Description}");
                    break;
                case EventType.Reminder:
                    sb.AppendLine($"REMINDER: {e.Date:yyyy-MM-dd HH:mm} - {e.Description}");
                    break;
                case EventType.Holiday:
                    sb.AppendLine($"HOLIDAY: {e.Date:yyyy-MM-dd} - {e.Description}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        return sb.ToString();
    }
}