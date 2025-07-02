namespace Design_Pattern_Demos.Patterns.Builder.Fluent_Builder.Solution;

public enum Transmission
{
    Manual,
    Automatic
}

public class Car
{
    internal Car() { }

    public string Make { get; internal set; } = string.Empty;
    public string Model { get; internal set; } = string.Empty;
    public Transmission Transmission { get; internal set; }
    public string Color { get; internal set; } = string.Empty;
    public bool Sunroof { get; internal set; }
    public bool Navigation { get; internal set; }

    public override string ToString() =>
        $"{Make} {Model}, {Transmission}, {Color}" +
        (Sunroof ? " with sunroof" : string.Empty) +
        (Navigation ? " with navigation" : string.Empty);
}

public class CarBuilder
{
    private readonly Car _car = new();

    public CarBuilder SetMake(string make)
    {
        _car.Make = make;
        return this;
    }

    public CarBuilder SetModel(string model)
    {
        _car.Model = model;
        return this;
    }

    public CarBuilder SetTransmission(Transmission transmission)
    {
        _car.Transmission = transmission;
        return this;
    }

    public CarBuilder Paint(string color)
    {
        _car.Color = color;
        return this;
    }

    public CarBuilder AddSunroof()
    {
        _car.Sunroof = true;
        return this;
    }

    public CarBuilder AddNavigation()
    {
        _car.Navigation = true;
        return this;
    }

    public Car Build() => _car;
}