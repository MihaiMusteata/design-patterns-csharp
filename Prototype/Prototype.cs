namespace Prototype;

// Prototype (interface)
public interface IDocumentPrototype
{
    IDocumentPrototype ShallowCopy();
    IDocumentPrototype DeepCopy();
}

// ConcretePrototype
public class PDFReader : IDocumentPrototype
{
    public DocumentInfo DocumentInfo { get; set; }

    public DateTime ReadDate { get; set; }

    public PDFReader()
    {
        DocumentInfo = new DocumentInfo("EMPTY", "N/A", "N/A");
    }


    public void Read()
    {
        Thread.Sleep(500);
        ReadDate = DateTime.UtcNow;
        DocumentInfo = new DocumentInfo("NEW_PDF", "A1", "C1");
    }

    // Shallow Copy
    public IDocumentPrototype ShallowCopy()
    {        
        return (PDFReader)this.MemberwiseClone();
    }

    // Deep Copy
    public IDocumentPrototype DeepCopy()
    {
        PDFReader copy = (PDFReader)this.MemberwiseClone();

        copy.DocumentInfo = new DocumentInfo(DocumentInfo);

        return copy;
    }
}