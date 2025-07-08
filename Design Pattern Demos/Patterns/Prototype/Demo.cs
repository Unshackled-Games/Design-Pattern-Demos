namespace Design_Pattern_Demos.Patterns.Prototype;

public class Person
{
    public string Name { get; set; } = "";
    public Person Clone() => (Person)MemberwiseClone();
}

public class Demo
{
    public static void Run()
    {
        var original = new Person { Name = "Alice" };
        var copy = original.Clone();
        Console.WriteLine(copy.Name);
    }
}
