namespace EventHandlerEx;

public class NotificationService
{
    public void SendNotification(object sender, EventArgs e)
    {
        System.Console.WriteLine("Notifikasi: Pembelian tiket berhasil");
    }
}
