namespace Strategy;

class PaypalPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment of paypal...");
        Console.WriteLine($"Calculating fees of the amount {amount} for paypal...");
    }
}
