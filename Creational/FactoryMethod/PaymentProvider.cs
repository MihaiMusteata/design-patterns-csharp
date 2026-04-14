namespace FactoryMethod;

// Clasă pentru selectarea creatorului
public class PaymentProvider
{
    // Mapare tip → creator
    private readonly Dictionary<string, Func<PaymentService>> _creators =
        new Dictionary<string, Func<PaymentService>>();

    public PaymentProvider()
    {
        _creators["paypal"] = () => new PaypalPaymentService();
        _creators["stripe"] = () => new StripePaymentService();
    }

    // Returnează serviciul potrivit fără a expune clasele concrete
    public PaymentService GetService(string type)
    {
        if (!_creators.ContainsKey(type))
            throw new ArgumentException("Unsupported type.....!");

        return _creators[type]();
    }
}