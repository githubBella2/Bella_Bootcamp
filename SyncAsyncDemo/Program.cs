class Program
{
    static async Task Main(string[] args)
    // static void Main(string[] args)
    {
        Synchronous();
        await Asynchronous();

        // await Synchronous2(); //kalau pakai await, panggil pakai await

    }

    static void Synchronous()
    {
        DoWork("eat");
        DoWork("drink");
    }
    static async void Synchronous2()
    {
        DoWork("mandi");
        DoWork("solat");
        await Asynchronous();
        DoWork("tidur");
    }

    static async Task Asynchronous()
    {
        Task eat = DoWorkAsync("eat async");
        Task drink = DoWorkAsync("drink async");
        await Task.WhenAll(eat, drink);
    }

    static void DoWork(string work)
    {
        System.Console.WriteLine($"{work} is started");
        Thread.Sleep(2000);
        System.Console.WriteLine($"{work} is finished");
    }

    static async Task DoWorkAsync(string work)
    {
        System.Console.WriteLine($"{work} is started");
        await Task.Delay(2000);
        System.Console.WriteLine($"{work} is finished");

    }
}