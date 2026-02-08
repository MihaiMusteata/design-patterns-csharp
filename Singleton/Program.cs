namespace Singleton;

public class Program
{
    public static void Main()
    {
        // Solicită instanța Singleton dintr-un thread
        void Run(string name)
        {
            Singleton instance = Singleton.GetInstance(name);
            Console.WriteLine(instance.Name);
        }

        // Thread 1
        var pr1 = new Thread(() =>
        {
            Run("1");
        });

        // Thread 2
        var pr2 = new Thread(() =>
        {
            Run("2");
        });

        // Execuție secvențială pentru evidențierea comportamentului
        pr1.Start();
        pr1.Join();

        pr2.Start();
        pr2.Join();
    }
}