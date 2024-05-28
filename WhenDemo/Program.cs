class Program
{
    // static async void Main(string[] args)
    static async Task Main(string[] args)
    {
        // Task task1 = Task.Run(() => System.Console.WriteLine("1" + "1"));
        // Task task2 = Task.Run(() => System.Console.WriteLine("Hello "));

        // // Task.WhenAll(task1, task2); 
        // Task.WaitAll(task1, task2); //blocking main thread
        // System.Console.WriteLine("Finished");

        Task task3 = Task.Run(async () =>
        {
            await Task.Delay(2000);
            System.Console.WriteLine("Task 3");
        });

        Task task4 = Task.Run(async () =>
        {
            await Task.Delay(2000);
            System.Console.WriteLine("Task 4");
        });

        Task completedTask = await Task.WhenAny(task3, task4);
        System.Console.WriteLine($"First completed task: " + (completedTask == task3 ? "Task 3" : "Task 4"));
    
    }
}