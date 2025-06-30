using Design_Pattern_Demos.SOLID.Open_Closed_Principle.Problem;
using Design_Pattern_Demos.SOLID.Open_Closed_Principle.Solution;

namespace Design_Pattern_Demos.SOLID.Open_Closed_Principle;

public class Demo {
    public static void Run()
    {
        Console.WriteLine("--- OCP violation example ---");
        var problemCalendar = new Problem.Calendar();
        problemCalendar.AddEvent(new CalendarEvent(DateTime.Today, "Project kickoff", EventType.Meeting));
        problemCalendar.AddEvent(new CalendarEvent(DateTime.Today.AddDays(1), "Submit report", EventType.Reminder));
        Console.WriteLine(problemCalendar.Export());

        Console.WriteLine("--- OCP solution example ---");
        var solutionCalendar = new Solution.Calendar();
        solutionCalendar.AddEvent(new MeetingEvent(DateTime.Today, "Project kickoff"));
        solutionCalendar.AddEvent(new ReminderEvent(DateTime.Today.AddDays(1), "Submit report"));
        Console.WriteLine(solutionCalendar.Export());
    }
}