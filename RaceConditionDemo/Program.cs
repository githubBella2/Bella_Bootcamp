class Program
{
    static int counter = 0; //resource yang akan diperebutkan
    static object key = new(); //kunci
    static async Task Main(string[] args)
    {
        Task task1 = IncrementCounterAsync();
        var task2 = IncrementCounterAsync();

        await Task.WhenAll(task1, task2);
        System.Console.WriteLine($"Final counter: {counter}");


    }

    static async Task IncrementCounterAsync()
    {
        lock (key)
        {
            for (int i = 0; i < 100; i++)
            {

                counter++;
                System.Console.WriteLine($"Counter from: {i}");

            }

        }
        await Task.Delay(100);

    }
}