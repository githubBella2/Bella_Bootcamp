namespace EventHandlerDemo;

public class Customer
{
    public void HandlePriceChanged(object sender, PriceChangedEventArgs e)
    {
        Console.WriteLine($"Old price: {e.OldPrice:C}");
        Console.WriteLine($"New price: {e.NewPrice:C}");
    }
}
