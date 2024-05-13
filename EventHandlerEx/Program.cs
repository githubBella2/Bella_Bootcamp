using EventHandlerEx;
class Program
{
    static void Main(string[] args)
    {
        Ticket ticket = new();
        NotificationService notif= new();
        ticket.TicketPurchased += notif.SendNotification;
        ticket.PurchaseTicket();
    }
}