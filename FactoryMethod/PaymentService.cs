namespace FactoryMethod;

// Creator
public abstract class PaymentService
{
    // Factory Method
    public abstract IPaymentProcessor Create();

    // Logică comună care folosește produsul
    public void Pay(double amount)
    {
        var product = Create();
        product.Process(amount);
        Console.WriteLine("Execute....");
    }
}