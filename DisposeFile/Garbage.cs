namespace DisposeFile;

public class Garbage : IDisposable
{
    public Pineapple spongebob;
    public FileStream file;
    public void Greeting()
    {
        System.Console.WriteLine("Hello Squidward!");
    }

    ~Garbage() //Destructor. Nama harus sama kayak bikin Constructor.
    {
        System.Console.WriteLine("");
    }

    public void Dispose()
    {
        Dispose(disposing:true);
        GC.SuppressFinalize(this);
    }
    private bool disposedValue = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                spongebob=null;
            }
        }
        file.Dispose();
        file= null;
        disposedValue=true;
    }
}
