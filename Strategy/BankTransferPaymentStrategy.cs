namespace Strategy;

class BankTransferPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment of bank transfer...");
    }
}
