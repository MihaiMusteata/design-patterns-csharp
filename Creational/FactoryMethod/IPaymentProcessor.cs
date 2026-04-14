namespace FactoryMethod;

// Product
public interface IPaymentProcessor
{
    // Operația specifică produsului
    void Process(double amount);
}
