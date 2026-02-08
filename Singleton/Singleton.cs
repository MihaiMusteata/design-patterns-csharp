namespace Singleton;

public class Singleton
{
    // Stare internă partajată prin instanța unică
    public string Name { get; set; }

    // Instanța unică a clasei
    private static Singleton? _instance;

    // Obiect de sincronizare pentru acces thread-safe
    private static readonly Lock _locker = new Lock();

    // Constructor privat – previne instanțierea directă (Singleton)
    private Singleton()
    {
    }

    // Acces global la instanța unică (lazy initialization)
    public static Singleton GetInstance(string name)
    {
        // Prima verificare fără lock (optimizare)
        if (_instance is null)
        {
            lock (_locker)
            {
                // A doua verificare – siguranță în medii multi-thread
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