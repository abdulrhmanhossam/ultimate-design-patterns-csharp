namespace Strategy;

class ReqularPricingStrategy : IPricingStrategy
{
    public double CalculatePrice(double price)
    {
        return price;
    }
}
