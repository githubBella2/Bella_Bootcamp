namespace DisposeCoba;

public class GameController : IDisposable
{
    // List<int> totalWin
    Dictionary<string, int> totalWin = new Dictionary<string, int>();
    public ExternalResource externalResource;
    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (disposed == false)
        {
            if (disposing)
            {
                totalWin=null;

            }
            externalResource=null;
            disposed=true;
        }
    }

    ~GameController(){
        Dispose(disposing:true);
    }
    public void Dispose(){
        Dispose(disposing:true);
        GC.SuppressFinalize(this);
    }
}

