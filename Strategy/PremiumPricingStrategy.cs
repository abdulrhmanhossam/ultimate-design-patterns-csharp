namespace Strategy;

class PremiumPricingStrategy : IPricingStrategy
{
    public double CalculatePrice(double price)
    {
        return price * 0.8; // 20% discount 
    }
}
