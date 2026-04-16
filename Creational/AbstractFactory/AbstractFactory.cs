namespace AbstractFactory;

// Fabrica abstractă - creează o familie de obiecte
public interface IPaymentFactory
{
    IPayment CreatePayment();
    IReceipt CreateReceipt();
}
