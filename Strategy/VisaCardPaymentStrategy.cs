namespace Strategy;

class VisaCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment of visa cards...");
        Console.WriteLine($"Calculating fees of the amount {amount} for visa card...");
    }
}
