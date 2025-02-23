namespace Strategy;

class Product
{
    private readonly IPricingStrategy _pricingStrategy;
    public Product(string name, double price, IPricingStrategy pricingStrategy)
    {
        Name = name;
        Price = price;
        _pricingStrategy = pricingStrategy;
    }

    public string Name { get; set; }
    public double Price { get; set; }

    public double CalculatePrice()
    {
        return _pricingStrategy.CalculatePrice(Price);
    }
}
