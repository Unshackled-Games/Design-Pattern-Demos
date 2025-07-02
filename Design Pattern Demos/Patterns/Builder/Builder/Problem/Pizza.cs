namespace Design_Pattern_Demos.Patterns.Builder.Builder.Problem;

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
    public Pizza(PizzaSize size, CrustType crust, bool extraCheese, bool pepperoni, bool bacon)
    {
        Size = size;
        Crust = crust;
        ExtraCheese = extraCheese;
        Pepperoni = pepperoni;
        Bacon = bacon;
    }

    public PizzaSize Size { get; }
    public CrustType Crust { get; }
    public bool ExtraCheese { get; }
    public bool Pepperoni { get; }
    public bool Bacon { get; }

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