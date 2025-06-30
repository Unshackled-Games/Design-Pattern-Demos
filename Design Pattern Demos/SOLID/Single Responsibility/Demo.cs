using Design_Pattern_Demos.SOLID.Single_Responsibility.Solution;

namespace Design_Pattern_Demos.SOLID.Single_Responsibility;


public class Demo {
    public static void Run()
    {
        Console.WriteLine("--- SRP violation example ---");
        var problemCalendar = new Problem.Calendar();
        problemCalendar.AddEvent(DateTime.Today, "Attend SOLID workshop");
        problemCalendar.AddEvent(DateTime.Today.AddDays(1), "Write demo code");
        problemCalendar.Save("calendar.txt");
        problemCalendar.Print();

        Console.WriteLine("--- SRP solution example ---");
        var calendar = new EventCalendar();
        calendar.AddEvent(DateTime.Today, "Attend SOLID workshop");
        calendar.AddEvent(DateTime.Today.AddDays(1), "Write demo code");
        var persistence = new CalendarPersistence();
        persistence.Save(calendar, "calendar-srp.txt");
        var printer = new CalendarPrinter();
        printer.Print(calendar);
    }
}