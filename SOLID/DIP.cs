namespace SOLID.DIP.Bad
{
    // ==== Bad Example ====
    public class EmailNotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Send EMAIL: {message}");
        }
    }

    public class OrderProcessor
    {
        private readonly EmailNotifier _notifier = new();

        public void Process()
        {
            Console.WriteLine("Processing order...");
            _notifier.Send("Order processed");
        }
    }
}

namespace SOLID.DIP.Good
{
    // ==== Good Example ====
    public interface INotifier
    {
        void Notify(string message);
    }

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
            _notifier.Notify("Order processed");
        }
    }
}
