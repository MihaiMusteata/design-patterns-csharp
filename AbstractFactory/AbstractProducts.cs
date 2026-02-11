namespace AbstractFactory;

// Produs abstract - definește comportamentul pentru plată
public interface IPayment
{
    void Pay();
}

// Produs abstract - definește comportamentul pentru receipt
public interface IReceipt
{
    void Download();
}