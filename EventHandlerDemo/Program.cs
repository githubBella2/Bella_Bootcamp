// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace EventHandlerDemo;

public static class Program
{
    // In the main program, create an instance of the Button class and subscribe to the Clicked event.
    public static void Main()
    {
        Form form = new Form();
        Button button = new Button();
        button.Clicked += form.HandleButtonClick;
        // Finally, raise the event by calling the event invoker method.
        button.OnClicked();



        Product product = new Product();
        Customer customer = new Customer();

        product.PriceChanged += customer.HandlePriceChanged;

        Console.WriteLine("Enter a new price:");
        string input = Console.ReadLine();
        decimal newPrice = decimal.Parse(input);
        product.Price = newPrice;

        // Door & Security
        SecuritySystem security = new();
        Door door = new();
        door.Opened += security.OnDoorOpened;
        door.Open();

    }
}