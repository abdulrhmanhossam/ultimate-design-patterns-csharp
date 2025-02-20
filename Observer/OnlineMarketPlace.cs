
namespace Observer;

class OnlineMarketPlace
{
    private List<User> users;
    private List<Product> products;
    private List<Offer> offers;

    public OnlineMarketPlace()
    {
        this.users = [];
        this.products = [];
        this.offers = [];
    }


    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AddNewProduct(Product product)
    {
        products.Add(product);
        NotifyUsers(product);
    }

    public void NotifyUsers(Product product)
    {
        foreach (var user in users)
        {
            if (!user.IsSubscribedToProducts)
                continue;
            else
                user.Notify(product);
        }
    }

    public void AddNewOffer(Offer offer)
    {
        offers.Add(offer);
        NotifyUsers(offer);
    }

    public void NotifyUsers(Offer offer)
    {
        foreach (var user in users)
        {
            if (!user.IsSubscribedToOffers)
                continue;

            user.Notify(offer);
        }
    }
}
