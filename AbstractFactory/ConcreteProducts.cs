namespace AbstractFactory;

// Produs concret din familia Stripe
public class StripePayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Stripe Pay");
    }
}

// Produs concret din familia Stripe
public class StripeReceipt : IReceipt
{
    public void Download()
    {
        Console.WriteLine("Stripe Download Receipt");
    }
}

// Produs concret din familia Crypto
public class CryptoPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Crypto Pay");
    }
}

// Produs concret din familia Crypto
public class CryptoReceipt : IReceipt
{
    public void Download()
    {
        Console.WriteLine("Crypto Download Receipt");
    }
}