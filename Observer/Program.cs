
using Observer;

class Program
{
    public static void Main(string[] args)
    {
        OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();
        
        ISubscribe ahmed = new Customer("ahmed");
        ISubscribe mahmoud = new Customer("Mahmoud");
        ISubscribe ziad = new Customer("Ziad");

        onlineMarketPlace.Subscribe(EventType.NEW_PRODUCT, ahmed);
        onlineMarketPlace.Subscribe(EventType.NEW_OFFER, ahmed);
        onlineMarketPlace.Subscribe(EventType.NEW_OFFER, mahmoud);
        onlineMarketPlace.Subscribe(EventType.NEW_PRODUCT, ziad);


        onlineMarketPlace.AddNewProduct(new Product
            ("Mobile", 1000.0));

        onlineMarketPlace.AddNewOffer(new Offer
            ("New offer with 20% discount for every item"));

    }
}
