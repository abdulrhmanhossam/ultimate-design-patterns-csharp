namespace Strategy;

class GoldPricingStrategy : IPricingStrategy
{
    public double CalculatePrice(double price)
    {
        return price * 0.9; // 10% discount 
    }
}
