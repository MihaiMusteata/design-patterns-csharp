namespace FactoryMethod;

// Concrete Product
public class PaypalPaymentProcessor : IPaymentProcessor
{
    public void Process(double amount)
    {
        Console.WriteLine("Paypal processing.....");
    }
}

// Concrete Product
public class StripePaymentProcessor : IPaymentProcessor
{
    public void Process(double amount)
    {
        Console.WriteLine("Stripe processing.....");
    }
}