namespace Observer;

class JopFinder : ISubscribe
{
    public JopFinder(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public void Notify(string message)
    {
        Console.WriteLine($"[{Name}] is receiving a " +
            $"notification about job finding: {message}");
    }
}
