namespace Observer;

class User
{
    public User(string name, bool isSubscribedToProducts,
        bool isSubscribedToOffers)
    {
        Name = name;
        IsSubscribedToProducts = isSubscribedToProducts;
        IsSubscribedToOffers = isSubscribedToOffers;
    }

    public string Name { get; set; }
    public bool IsSubscribedToProducts { get; set; }
    public bool IsSubscribedToOffers { get; set; }

    public void Notify(Product product)
    {
        Console.WriteLine($"Notifying user [{Name}] about new " +
            $"product {product.Name}");
    }

    public void Notify(Offer offer)
    {
        Console.WriteLine($"Notifying user: [{Name}] about new " +
            $"offer {offer.Message}");
    }
}
