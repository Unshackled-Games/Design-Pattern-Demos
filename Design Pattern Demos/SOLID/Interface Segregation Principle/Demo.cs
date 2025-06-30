namespace Design_Pattern_Demos.SOLID.Interface_Segregation_Principle;

public class Demo {
    public static void Run()
    {
        Console.WriteLine("--- ISP violation example ---");
        Problem.ICalendar desktopProblem = new Problem.DesktopCalendar();
        desktopProblem.AddEvent(DateTime.Today, "Write code");
        try
        {
            desktopProblem.SyncWithCloud();
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        desktopProblem.Print();

        Console.WriteLine("--- ISP solution example ---");
        var desktopCalendar = new Solution.DesktopCalendar();
        desktopCalendar.AddEvent(DateTime.Today, "Write code");
        desktopCalendar.Print();
        var cloudCalendar = new Solution.CloudCalendar();
        cloudCalendar.AddEvent(DateTime.Today, "Write code");
        cloudCalendar.SyncWithCloud();
        cloudCalendar.Print();
    }
}