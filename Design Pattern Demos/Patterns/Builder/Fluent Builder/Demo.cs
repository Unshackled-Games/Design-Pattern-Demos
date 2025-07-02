namespace Design_Pattern_Demos.Patterns.Builder.Fluent_Builder;

public class Demo
{
    public static void Run()
    {
        Console.WriteLine("--- Fluent Builder problem example ---");
        var problemCar = new Problem.Car(
            "Ford",
            "Fusion",
            Problem.Transmission.Automatic,
            "Blue",
            sunroof: true,
            navigation: true);
        Console.WriteLine(problemCar);

        Console.WriteLine("--- Fluent Builder solution example ---");
        var car = new Solution.CarBuilder()
            .SetMake("Ford")
            .SetModel("Fusion")
            .SetTransmission(Solution.Transmission.Automatic)
            .Paint("Blue")
            .AddSunroof()
            .AddNavigation()
            .Build();
        Console.WriteLine(car);
    }
}