namespace Design_Pattern_Demos.SOLID.Liskov_Substitution_Principle;

public class Demo {
    public static void Run()
    {
        Console.WriteLine("--- LSP violation example ---");
        var readOnlyProblem = new Problem.ReadOnlyCalendar();
        var schedulerProblem = new Problem.EventScheduler(readOnlyProblem);
        try
        {
            schedulerProblem.ScheduleEvent(DateTime.Today, "Team meeting");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("--- LSP solution example ---");
        var calendar = new Solution.Calendar();
        var scheduler = new Solution.EventScheduler(calendar);
        scheduler.ScheduleEvent(DateTime.Today, "Team meeting");
        var readOnly = new Solution.ReadOnlyCalendar(calendar);
        Console.WriteLine(string.Join(Environment.NewLine, readOnly.Events));
    }
}