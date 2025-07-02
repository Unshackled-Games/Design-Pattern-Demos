namespace Design_Pattern_Demos.Patterns.Builder.Builder.Solution;

public enum PizzaSize
{
    Small,
    Medium,
    Large
}

public enum CrustType
{
    Thin,
    Thick
}

public class Pizza
{
    internal Pizza() { }

    public PizzaSize Size { get; internal set; }
    public CrustType Crust { get; internal set; }
    public bool ExtraCheese { get; internal set; }
    public bool Pepperoni { get; internal set; }
    public bool Bacon { get; internal set; }

    public override string ToString()
    {
        var toppings = new List<string>();
        if (ExtraCheese) toppings.Add("extra cheese");
        if (Pepperoni) toppings.Add("pepperoni");
        if (Bacon) toppings.Add("bacon");

        return $"{Size} {Crust} crust pizza with " +
               (toppings.Count > 0 ? string.Join(", ", toppings) : "no toppings");
    }
}

public class PizzaBuilder
{
    private readonly Pizza _pizza = new();

    public PizzaBuilder(PizzaSize size, CrustType crust)
    {
        _pizza.Size = size;
        _pizza.Crust = crust;
    }

    public PizzaBuilder AddExtraCheese()
    {
        _pizza.ExtraCheese = true;
        return this;
    }

    public PizzaBuilder AddPepperoni()
    {
        _pizza.Pepperoni = true;
        return this;
    }

    public PizzaBuilder AddBacon()
    {
        _pizza.Bacon = true;
        return this;
    }

    public Pizza Build() => _pizza;
}