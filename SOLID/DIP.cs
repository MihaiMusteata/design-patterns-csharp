namespace SOLID;

// ==== Bad Example ====
// Detaliu concret
public class EmailNotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Send EMAIL: {message}");
    }
}

// Nivel înalt – depinde direct de EmailNotifier
public class OrderProcessor
{
    // Problema: OrderProcessor este strâns cuplat de EmailNotifier
    private readonly EmailNotifier _notifier = new EmailNotifier();

    public void Process()
    {
        Console.WriteLine("Processing order...");
        _notifier.Send("Order processed");
    }
}


// ==== Good Example ====
// Abstracție
public interface INotifier
{
    void Notify(string message);
}

// Detalii concrete
public class EmailNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Send EMAIL: {message}");
    }
}

public class SmsNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Send SMS: {message}");
    }
}

// Nivel înalt – depinde de abstracție
public class OrderProcessor
{
    private readonly INotifier _notifier;

    public OrderProcessor(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Process()
    {
        Console.WriteLine("Processing order...");
        // aici ar veni logica reală de procesare
        _notifier.Notify("Order processed");
    }
}