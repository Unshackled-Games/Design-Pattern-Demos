namespace Design_Pattern_Demos.Patterns.Mediator;

public class ChatRoom
{
    private readonly List<User> _users = new();
    public void Register(User user) => _users.Add(user);
    public void Broadcast(string from, string message)
    {
        foreach (var u in _users)
            if (u.Name != from) u.Receive(from, message);
    }
}

public class User
{
    private readonly ChatRoom _room;
    public string Name { get; }
    public User(string name, ChatRoom room)
    {
        Name = name; _room = room; _room.Register(this);
    }
    public void Send(string message) => _room.Broadcast(Name, message);
    public void Receive(string from, string message) => Console.WriteLine($"{from}: {message}");
}

public class Demo
{
    public static void Run()
    {
        var room = new ChatRoom();
        var alice = new User("Alice", room);
        var bob = new User("Bob", room);
        alice.Send("Hi Bob");
    }
}
