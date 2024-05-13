namespace EventHandlerDemo;
public delegate void PriceChangedEventHandler(object sender, PriceChangedEventArgs e);

public class PriceChangedEventArgs : EventArgs
{
    public decimal OldPrice { get; set; }
    public decimal NewPrice { get; set; }
}
public class Product
{
    private decimal price;

    public event PriceChangedEventHandler PriceChanged;

    public decimal Price
    {
        get { return price; }
        set
        {
            if (price != value)
            {
                PriceChangedEventArgs args = new PriceChangedEventArgs
                {
                    OldPrice = price,
                    NewPrice = value
                };

                price = value;
                OnPriceChanged(args);
            }
        }
    }
     protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        if (PriceChanged != null)
        {
            PriceChanged(this, e);
        }
    }
}


