namespace DelegateDemo;
public delegate void Notification(); //alias dari method
public class DelegateEmail
{
    public void EmailNotify()
    {
        System.Console.WriteLine("Email got notified");
    }
    public void SMSNotify()
    {
        System.Console.WriteLine("SMS got notified");
    }
}
