using FactoryMethod;

class Program
{
    static void Main()
    {
        // Clientul utilizează furnizorul pentru a obține serviciile dorite
        PaymentProvider provider = new PaymentProvider();

        var service = provider.GetService("stripe");
        service.Pay(100);

        // Alternativ: schimbarea implementării fără modificări în logică
        service = provider.GetService("paypal");
        service.Pay(200);
    }
}