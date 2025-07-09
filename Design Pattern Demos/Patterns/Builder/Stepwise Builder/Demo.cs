namespace Design_Pattern_Demos.Patterns.Builder.Stepwise_Builder;

public class Car
{
    public string Brand { get; set; } = string.Empty;
    public int Seats { get; set; }
    public string Engine { get; set; } = string.Empty;
    public bool Sunroof { get; set; }

    public override string ToString() =>
        $"{Brand} with {Engine} engine, {Seats} seats" + (Sunroof ? " and sunroof" : string.Empty);
}

public interface ICarBrandStage
{
    ICarSeatStage SetBrand(string brand);
}

public interface ICarSeatStage
{
    ICarEngineStage SetSeats(int seats);
}

public interface ICarEngineStage
{
    ICarOptionalStage SetEngine(string engine);
}

public interface ICarOptionalStage
{
    ICarOptionalStage AddSunroof();
    Car Build();
}

public class CarBuilder : ICarBrandStage, ICarSeatStage, ICarEngineStage, ICarOptionalStage
{
    private readonly Car _car = new();
    private CarBuilder() { }

    public static ICarBrandStage Create() => new CarBuilder();

    public ICarSeatStage SetBrand(string brand)
    {
        _car.Brand = brand;
        return this;
    }

    public ICarEngineStage SetSeats(int seats)
    {
        _car.Seats = seats;
        return this;
    }

    public ICarOptionalStage SetEngine(string engine)
    {
        _car.Engine = engine;
        return this;
    }

    public ICarOptionalStage AddSunroof()
    {
        _car.Sunroof = true;
        return this;
    }

    public Car Build() => _car;
}

public class Demo
{
    public static void Run()
    {
        var car = CarBuilder.Create()
            .SetBrand("Tesla")
            .SetSeats(5)
            .SetEngine("Electric")
            .AddSunroof()
            .Build();
        Console.WriteLine(car);
    }
}