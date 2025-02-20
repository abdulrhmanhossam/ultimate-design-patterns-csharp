namespace Observer;

class Product
{
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public double Price { get; set; }

}
