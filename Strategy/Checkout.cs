namespace Strategy;

class Checkout
{
    public void ProcessPayment(double amount, PaymentMehtod paymentMethod)
    {
        if (paymentMethod == PaymentMehtod.VISA_CARD)
        {
            Console.WriteLine("Processing payment of visa cards...");
            Console.WriteLine("Calculating fees of the amount for visa card...");
        }
        else if (paymentMethod == PaymentMehtod.PAYPAL)
        {
            Console.WriteLine("Processing payment of paypal...");
            Console.WriteLine("Calculating fees of the amount for paypal...");
        }
        else if (paymentMethod == PaymentMehtod.BANK_TRANSFER)
        {
            Console.WriteLine("Processing payment of bank transfer...");
        }
    }
}
