namespace AbstractFactory;

// Creează familia Stripe
public class StripeFactory : IPaymentFactory
{
    public IPayment CreatePayment() => new StripePayment();
    public IReceipt CreateReceipt() => new StripeReceipt();
}

// Creează familia Crypto
public class CryptoFactory : IPaymentFactory
{
    public IPayment CreatePayment() => new CryptoPayment();
    public IReceipt CreateReceipt() => new CryptoReceipt();
}