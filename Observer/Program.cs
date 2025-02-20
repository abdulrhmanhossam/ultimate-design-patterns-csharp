
using Observer;

class Program
{
    public static void Main(string[] args)
    {
        OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();
        onlineMarketPlace.AddUser(new User 
            ("Ahmed", true, true));
        onlineMarketPlace.AddUser(new User
            ("Mahmoud", false, true));
        onlineMarketPlace.AddUser(new User
            ("Ziad", true, false));
        onlineMarketPlace.AddUser(new User
            ("Hossam", false, false));


        onlineMarketPlace.AddNewProduct(new Product
            ("Mobile", 1000.0));

    }
}
