// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static async Task Main(string[] args)
    // static async void Main(string[] args)
    {
        System.Console.WriteLine("Program dimulai");
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        cancellationTokenSource.Cancel();

        Task<int> task = Task.Run(() =>
        {
            Task.Delay(2000).Wait();
            return 43;
        });

        System.Console.WriteLine("Melanjutkan eksekusi lainnya sambil menunggu task selesai...");

        // int result = await task;
        // menunggu tas selesai tanpa menggunakan await
        while (!task.IsCompleted)
        {
            System.Console.WriteLine("Menunggu task selesai");
            Task.Delay(500).Wait();
        }

        if (task.IsCompleted)
        {
            System.Console.WriteLine("Task selesai");
            if (task.IsCanceled)

            {
                System.Console.WriteLine("Task dibatalkan");

            }
            else if (task.IsFaulted)
            {
                System.Console.WriteLine("Task gagal");
            }
            else
            {
                // task selesai tanpa masalah
                int result = task.Result;
                System.Console.WriteLine("Hasil" + result);

            }
        }



        // System.Console.WriteLine("Hasil" + result);
        System.Console.WriteLine("Program selesai");

    }
}