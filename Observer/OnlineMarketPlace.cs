namespace Observer;

class OnlineMarketPlace
{
    private Dictionary<EventType, List<ISubscribe>> _subscribers;
    private List<Product> _products;
    private List<Offer> _offers;
    private List<JopFinder> _jobFinder;

    public OnlineMarketPlace()
    {
        this._subscribers = [];
        InitSubscriberEvents();
        this._products = [];
        this._offers = [];
        this._jobFinder = [];
    }

    public void InitSubscriberEvents()
    {
        _subscribers.Add(EventType.NEW_PRODUCT, []);
        _subscribers.Add(EventType.NEW_OFFER, []);
        _subscribers.Add(EventType.JOB_OPENING, []);
    }

    public void Subscribe(EventType eventType, ISubscribe subscribe)
    {
        _subscribers.GetValueOrDefault(eventType)!.Add(subscribe);
    }

    public void UnSubscribe(EventType eventType, ISubscribe subscribe)
    {
        _subscribers.GetValueOrDefault(eventType)!.Remove(subscribe);
    }

    public void AddNewProduct(Product product)
    {
        _products.Add(product);
        NotifySubscribers(EventType.NEW_PRODUCT, 
            $"New product is added {product.Name}");
    }

    public void AddNewOffer(Offer offer)
    {
        _offers.Add(offer);
        NotifySubscribers(EventType.NEW_OFFER,
            $"New product is added {offer.Message}");
    }

    public void AddNewJobOpening(JopFinder jopFinder)
    {
        _jobFinder.Add(jopFinder);
        NotifySubscribers(EventType.JOB_OPENING,
            $"New opening position available {jopFinder.Name}");
    }

    public void NotifySubscribers(EventType eventType, string message)
    {

        if (_subscribers.TryGetValue(eventType, out var eventSubscribers))
        {
            foreach (var subscribe in eventSubscribers)
            {
                subscribe.Notify(message);
            }
        }
    }
}
