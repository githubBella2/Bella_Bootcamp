// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{ // TASK
    static void Main(string[] args)
    {
        // Task task1 = new(() => System.Console.WriteLine("Task 1"));
        // task1.Start();
        // // task1.RunSynchronously();
        // task1.Wait();

        Task task2 = new Task(() =>
        {
            System.Console.WriteLine("T2");
            Thread.Sleep(6000);
            System.Console.WriteLine("Tasl 2 complete");
        }
        );

        Task task3 = new Task(
            () =>
            {
                System.Console.WriteLine("T3");
                Thread.Sleep(1200);
                System.Console.WriteLine("Task 3 complete");
            }
        );

        task2.Start();
        task3.Start();

        System.Console.WriteLine("Task 2 running");
        System.Console.WriteLine("Task 3 running");

        // task2.Wait();
        // System.Console.WriteLine("task 1 done");
        // task3.Wait();
        Task.WaitAll(task2, task3);
        System.Console.WriteLine("task 2 done");


        Task task5 = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("+");
                Thread.Sleep(5);
            }
        });

        System.Console.WriteLine(task5.IsCompleted);
        System.Console.WriteLine(task5.IsCanceled);
        System.Console.WriteLine(task5.IsFaulted);

        Task.WaitAll(task5);
        System.Console.WriteLine(task5.IsCompleted); //tugasnya udah selesai atau belum
        System.Console.WriteLine(task5.IsCanceled);// pakai cancellation token
        System.Console.WriteLine(task5.IsFaulted);//buat ngecek apakah tugasnya mengalami kegagalan dan ada exception

    }

}