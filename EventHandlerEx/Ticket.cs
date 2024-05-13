namespace EventHandlerEx;

public class Ticket
{
    public event EventHandler TicketPurchased;

    public void PurchaseTicket()
    {
        System.Console.WriteLine("Ticket berhasil dibeli");
        // TicketPurchased?.Invoke(this, EventArgs.Empty);
        OnTicketPurchased();
    }

    protected virtual void OnTicketPurchased()
    {
        TicketPurchased?.Invoke(this, EventArgs.Empty);
    }



}
