using Strategy;

class Program
{
    static void Main()
    {
        Product wallet = new Product("Wallet", 200.0);
        double walletPrice = wallet
            .CalculatePrice(MembershipType.REGULAR);

        Console.WriteLine(walletPrice);

        Product jacket = new Product("Jacket", 100.0);
        double jacketPrice = jacket
            .CalculatePrice(MembershipType.GOLD);

        Console.WriteLine(jacketPrice);

        Product mobile = new Product("Mobile", 1000.0);
        double mobilePrice = mobile
            .CalculatePrice(MembershipType.PREMIUM);
        
        Console.WriteLine(mobilePrice);


        Checkout checkout = new Checkout();

        checkout.ProcessPayment(walletPrice, PaymentMehtod.VISA_CARD);
        checkout.ProcessPayment(jacketPrice, PaymentMehtod.PAYPAL);
        checkout.ProcessPayment(mobilePrice, PaymentMehtod.BANK_TRANSFER);
    }
}
