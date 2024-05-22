namespace DisposeDemoo;

public class ResourceHandle : IDisposable
{
    // mengisi filend yang berhubungan dengan hal-hal IO
    private MemoryStream managedResource;
    private FileStream unmanagedResource;


    // untuk menjembatani dispose 
    public bool dispose = false;


    // Constructor
    public ResourceHandle(string filePath)
    {
        managedResource = new MemoryStream();
        unmanagedResource = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    }

    public void Dispose()
    {
        
    }

    //



}
