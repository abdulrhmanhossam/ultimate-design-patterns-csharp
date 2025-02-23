using Strategy;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        Product wallet = new Product
            ("Wallet", 200.0 , new ReqularPricingStrategy());
        double walletPrice = wallet.CalculatePrice();

        Console.WriteLine(walletPrice);

        Product jacket = new Product
            ("Jacket", 100.0, new GoldPricingStrategy());
        double jacketPrice = jacket.CalculatePrice();

        Console.WriteLine(jacketPrice);

        Product mobile = new Product
            ("Mobile", 1000.0, new PremiumPricingStrategy());
        double mobilePrice = mobile.CalculatePrice();
        
        Console.WriteLine(mobilePrice);


        new Checkout(new VisaCardPaymentStrategy())
            .ProcessPayment(walletPrice);
        new Checkout(new PaypalPaymentStrategy())
            .ProcessPayment(jacketPrice);
        new Checkout(new BankTransferPaymentStrategy())
            .ProcessPayment(mobilePrice);
    }
}
