class Program
{
    // Membuat semaphore dengan kapasitas maksimum 3 thread
    // static Semaphore semaphore = new Semaphore(3, 3);

    static void Main(string[] args)
    {
        // for (int i = 0; i < 10; i++)
        // {
        //     Thread thread = new Thread(new ParameterizedThreadStart(AccessResource));
        //     thread.Start(i);
        // }

        #region YT
        // SemaphoreSlim();
        SemaphoreTest();
        Console.ReadLine();
        #endregion
    }

    #region GPT
    static void AccessResource(object id)
    {

        // Console.WriteLine($"Thread {id} sedang menunggu untuk memasuki semaphore.");
        // semaphore.WaitOne(); // Memasuki semaphore

        // Console.WriteLine($"Thread {id} telah memasuki semaphore.");
        // // Simulasi pekerjaan dengan tidur selama 2 detik
        // Thread.Sleep(2000);

        // Console.WriteLine($"Thread {id} keluar dari semaphore.");
        // semaphore.Release(); // Keluar dari semaphore
    }
    #endregion
    #region YT
    static void SemaphoreSlim()
    {

        var semaphore = new SemaphoreSlim(2, 2);
        for (int i = 0; i <= 2; i++)
        {
            Task.Run(() =>
            {
                System.Console.WriteLine("Task {0} wait", Task.CurrentId);
                semaphore.Wait();

                System.Console.WriteLine("Task {0} enters the semaphore.", Task.CurrentId);
                Thread.Sleep(1000 * ((int)Task.CurrentId + 1));

                System.Console.WriteLine("Task {0} releases the semaphore.", Task.CurrentId);
                semaphore.Release();
            });
        }
    }



    static void SemaphoreTest()
    {

        var semaphore = new Semaphore(2, 2, "systemSemaphore");
        for (int i = 0; i <= 2; i++)
        {
            Task.Run(() =>
            {
                System.Console.WriteLine("Task {0} wait", Task.CurrentId);
                semaphore.WaitOne();

                System.Console.WriteLine("Task {0} enters the semaphore.", Task.CurrentId);
                Thread.Sleep(1000 * ((int)Task.CurrentId + 1));

                System.Console.WriteLine("Task {0} releases the semaphore.", Task.CurrentId);
                semaphore.Release();
            });
        }
    }
    #endregion

}