namespace AbstractFactory;

public class Program
{
    public static void Main()
    {
        IPaymentFactory factory = new CryptoFactory(); // alegem familia

        Checkout checkout = new Checkout(factory);
        checkout.Process();
    }
}