namespace Prototype;
// Client
static class Program
{
    static void Main()
    {
        PDFReader original = new PDFReader();
        original.Read();

        Console.WriteLine("Original:");
        original.DocumentInfo.Print();

        Console.WriteLine("\n--- Shallow Copy ---");
        PDFReader shallow = (PDFReader)original.ShallowCopy();

        original.DocumentInfo.Author = "Changed Author";

        Console.WriteLine("Shallow copy reflects change:");
        shallow.DocumentInfo.Print();

        Console.WriteLine("\n--- Deep Copy ---");
        PDFReader deep = (PDFReader)original.DeepCopy();

        original.DocumentInfo.Author = "Changed Again";

        Console.WriteLine("Deep copy remains unchanged:");
        deep.DocumentInfo.Print();
    }
}