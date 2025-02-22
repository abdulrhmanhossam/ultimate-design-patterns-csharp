namespace Strategy;

class Product
{
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public double Price { get; set; }

    public double CalculatePrice(MembershipType membershipType)
    {
        if (membershipType == MembershipType.REGULAR)
            return Price;
        else if (membershipType == MembershipType.GOLD)
            return Price * 0.9; // 10% discount
        else if (membershipType == MembershipType.PREMIUM)
            return Price * 0.8; // 20% discount

        return Price;
    }
}
