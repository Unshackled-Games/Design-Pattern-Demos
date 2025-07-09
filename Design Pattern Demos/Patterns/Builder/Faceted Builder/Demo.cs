namespace Design_Pattern_Demos.Patterns.Builder.Faceted_Builder;

public class Person
{
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public int AnnualIncome { get; set; }

    public override string ToString() =>
        $"Lives at {StreetAddress}, {City}. Works at {Company} as {Position} earning {AnnualIncome}.";
}

// Facade builder
public class PersonBuilder
{
    protected Person Person = new();
    public PersonAddressBuilder Lives => new(Person);
    public PersonJobBuilder Works => new(Person);
    public Person Build() => Person;
}

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person) => Person = person;

    public PersonAddressBuilder At(string street)
    {
        Person.StreetAddress = street;
        return this;
    }

    public PersonAddressBuilder In(string city)
    {
        Person.City = city;
        return this;
    }
}

public class PersonJobBuilder : PersonBuilder
{
    public PersonJobBuilder(Person person) => Person = person;

    public PersonJobBuilder At(string company)
    {
        Person.Company = company;
        return this;
    }

    public PersonJobBuilder AsA(string position)
    {
        Person.Position = position;
        return this;
    }

    public PersonJobBuilder Earning(int income)
    {
        Person.AnnualIncome = income;
        return this;
    }
}

public class Demo
{
    public static void Run()
    {
        var builder = new PersonBuilder();
        Person person = builder
            .Lives.At("123 Main St").In("Denver")
            .Works.At("Acme Corp").AsA("Engineer").Earning(120000)
            .Build();
        Console.WriteLine(person);
    }
}