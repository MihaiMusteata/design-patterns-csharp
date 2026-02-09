namespace FactoryMethod;

// Concrete Creator
public class PaypalPaymentService : PaymentService
{
    public override IPaymentProcessor Create()
    {
        return new PaypalPaymentProcessor();
    }
}

// Concrete Creator
public class StripePaymentService : PaymentService
{
    public override IPaymentProcessor Create()
    {
        return new StripePaymentProcessor();
    }
}