using System;

namespace Observer;

class Customer : ISubscribe
{
    public Customer(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void Notify(string message)
    {
        Console.WriteLine($"Notifying user: [{Name}] about: {message} ");
    }
}
