namespace Design_Pattern_Demos.Patterns.Builder.Functional_Builder;

public class Email
{
    public string From { get; set; } = string.Empty;
    public string To { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;

    public override string ToString() =>
        $"From: {From}, To: {To}, Subject: {Subject}, Body: {Body}";
}

public class EmailBuilder
{
    private readonly List<Action<Email>> _actions = new();

    public EmailBuilder FromAddress(string from) => Add(e => e.From = from);
    public EmailBuilder ToAddress(string to) => Add(e => e.To = to);
    public EmailBuilder WithSubject(string subject) => Add(e => e.Subject = subject);
    public EmailBuilder WithBody(string body) => Add(e => e.Body = body);

    private EmailBuilder Add(Action<Email> action)
    {
        _actions.Add(action);
        return this;
    }

    public Email Build()
    {
        var email = new Email();
        foreach (var action in _actions)
            action(email);
        return email;
    }
}

public class Demo
{
    public static void Run()
    {
        var email = new EmailBuilder()
            .FromAddress("sales@example.com")
            .ToAddress("customer@domain.com")
            .WithSubject("Welcome")
            .WithBody("Thank you for registering!")
            .Build();
        Console.WriteLine(email);
    }
}