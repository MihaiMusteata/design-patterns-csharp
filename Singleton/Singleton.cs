namespace Singleton;

public class Singleton
{
    // Stare internă partajată prin instanța unică
    public string Name { get; private set; } = string.Empty;

    // Instanța unică a clasei
    private static Singleton? _instance;

    // Obiect de sincronizare pentru acces thread-safe
    private static readonly Lock _locker = new();

    // Constructor privat – previne instanțierea directă
    private Singleton()
    {
    }

    // Acces global la instanța unică
    public static Singleton GetInstance(string name)
    {
        if (_instance is null)
        {
            lock (_locker)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                    _instance.Name = name;
                }
            }
        }

        return _instance;
    }
}
