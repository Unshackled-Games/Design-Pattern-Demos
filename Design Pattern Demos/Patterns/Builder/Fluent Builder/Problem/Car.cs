namespace Design_Pattern_Demos.Patterns.Builder.Fluent_Builder.Problem;

public enum Transmission
{
    Manual,
    Automatic
}

public class Car
{
    public Car(string make, string model, Transmission transmission,
        string color, bool sunroof, bool navigation)
    {
        Make = make;
        Model = model;
        Transmission = transmission;
        Color = color;
        Sunroof = sunroof;
        Navigation = navigation;
    }

    public string Make { get; }
    public string Model { get; }
    public Transmission Transmission { get; }
    public string Color { get; }
    public bool Sunroof { get; }
    public bool Navigation { get; }

    public override string ToString() =>
        $"{Make} {Model}, {Transmission}, {Color}" +
        (Sunroof ? " with sunroof" : string.Empty) +
        (Navigation ? " with navigation" : string.Empty);
}