class Program
{
    static async Task Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        // Console.WriteLine("Hello, World!");

        CancellationTokenSource cts = new();
        CancellationToken token = cts.Token;

        Task task = DoWorkAsync(token);
        System.Console.WriteLine("Press 'c' to cancel the operation");
        if (Console.ReadKey().KeyChar == 'c')
        {
            cts.Cancel();
        }

        try
        {
            await task; //masih error
            System.Console.WriteLine("Operation completed");
        }
        catch (OperationCanceledException e)
        {
            System.Console.WriteLine("Operation cancelled");
        }

        static async Task DoWorkAsync(CancellationToken token)
        {
            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();
                System.Console.WriteLine($"Work in progress: {i * 10}%");
                await Task.Delay(2000, token);
            }
        }
    }

}