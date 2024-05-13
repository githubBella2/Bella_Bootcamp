namespace EventHandlerDemo;

public class Door
{
    public event EventHandler Opened;

    public void Open()
    {
        System.Console.WriteLine("Door is open");
        Opened?.Invoke(this, EventArgs.Empty);

    }
}
