namespace AbstractFactory;

// Clientul folosește fabrica fără să știe implementarea
public class Checkout
{
    private readonly IPayment _payment;
    private readonly IReceipt _receipt;

    public Checkout(IPaymentFactory factory)
    {
        _payment = factory.CreatePayment();
        _receipt = factory.CreateReceipt();
    }

    public void Process()
    {
        _payment.Pay();
        _receipt.Download();
    }
}