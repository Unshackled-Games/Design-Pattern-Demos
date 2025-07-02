namespace Design_Pattern_Demos.Patterns.Builder.Builder;

public class Demo {
    public static void Run()
    {
        Console.WriteLine("--- Builder problem example ---");
        var problemPizza = new Problem.Pizza(Problem.PizzaSize.Large, Problem.CrustType.Thick, true, true, false);
        Console.WriteLine(problemPizza);

        Console.WriteLine("--- Builder solution example ---");
        var pizza = new Solution.PizzaBuilder(Solution.PizzaSize.Large, Solution.CrustType.Thick)
            .AddExtraCheese()
            .AddPepperoni()
            .Build();
        Console.WriteLine(pizza);
    }
    
    public static void RunHTML()
    {
        Console.WriteLine("--- HTML problem example ---");
        var html = new Problem.Html();
        html.Demo();
        
        Console.WriteLine("--- HTML solution example ---");
        var html2 = new Solution.Html();
        html2.Demo();
    }
}