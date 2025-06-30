using Design_Pattern_Demos.SOLID.Single_Responsibility.Problem;
using Design_Pattern_Demos.SOLID.Single_Responsibility.Solution;

namespace Design_Pattern_Demos;

class Program
{
    static void Main(string[] args)
    {
        // --- SRP violation example ---
        var problemCalendar = new Calendar();
        problemCalendar.AddEvent(DateTime.Today, "Attend SOLID workshop");
        problemCalendar.AddEvent(DateTime.Today.AddDays(1), "Write demo code");

        // This call mixes persistence with scheduling
        problemCalendar.Save("calendar.txt");

        // Presentation logic also lives inside the CalendarProblem class
        problemCalendar.Print();

        // --- SRP-compliant example ---
        var calendar = new EventCalendar();
        calendar.AddEvent(DateTime.Today, "Attend SOLID workshop");
        calendar.AddEvent(DateTime.Today.AddDays(1), "Write demo code");

        var persistence = new CalendarPersistence();
        persistence.Save(calendar, "calendar-srp.txt");

        var printer = new CalendarPrinter();
        printer.Print(calendar);
    }
}