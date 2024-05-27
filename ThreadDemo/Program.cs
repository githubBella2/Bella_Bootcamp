// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //-- output 1, karena menunjukkan bahwa printer dan printer2 berjalan di Thread yang sama.
        // --Hal ini, synchronous.
        // Printer();
        // Printer2();
        // CalculateSum(2, 10);
        // DisplayMessage("Tes hello world");
        // System.Console.WriteLine("END");

        // MULTITHREAD
        // Thread thread = new( ()=> PrinterMul());
        Thread thread = new(PrinterMul);
        Thread thread2 = new(PrinterMul2);
        Thread thread3 = new(PrinterMul3);
        Thread thread4 = new(PrinterMul4);
        thread.IsBackground = true; // mengubah foreground thread menjadi backgorund thread
        thread.Name = "Alex Thread";
        thread.Priority = ThreadPriority.Highest;
        thread.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();

        System.Console.WriteLine("Program finished");

        System.Console.WriteLine("Latihan start");
        Thread th1 = new Thread(CountNumbers);
        Thread th2 = new Thread(DisplayMessageMul);
        th1.Start();
        th2.Start();
        th1.Join();
        th2.Join();

        System.Console.WriteLine("Latihan done");

        Thread thDel = new Thread(DelegateThread);
        thDel.Start();

        // THREAD dengan return value
        Thread threadAdd = new Thread(CallThreadAdd);
        threadAdd.Start();
        Thread threadMultiply = new Thread(CallThreadMultiply);
        threadMultiply.Start();
    }
    static void Printer()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine("printer");
        }
    }
    static void Printer2()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine("printer2");
        }
    }

    static void Printer3()
    {

    }

    static int CalculateSum(int a, int b)
    {
        return a + b;
    }
    static void DisplayMessage(string pesan)
    {
        System.Console.WriteLine(pesan);
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }

    static void PrinterMul()
    {
        System.Console.WriteLine("Printer1");
    }
    static void PrinterMul2()
    {
        System.Console.WriteLine("Printer2");
    }
    static void PrinterMul3()
    {
        System.Console.WriteLine("Printer3");

    }
    static void PrinterMul4()
    {
        System.Console.WriteLine("Printer4");

    }

    static void CountNumbers()
    {
        for (int i = 0; i <= 5; i++)
        {
            System.Console.WriteLine("Thread 1: " + i);
            Thread.Sleep(500);
        }
    }
    static void DisplayMessageMul()
    {
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("Thread 2: Pesan dari thread kedua");
            Thread.Sleep(500);
        }
    }
    static void DelegateThread()
    {
        // Func<int> getRandomNumber = () => new Random().Next(1,100);
        Func<int> getRandomNumber = new Func<int>(RandomNumber);
        System.Console.WriteLine("Thread with name " + Thread.CurrentThread.Name + " is generate random number : " + getRandomNumber.Invoke());
    }

    static int RandomNumber()
    {
        // --Method ini, untuk dipanggil dari func diatas.
        return new Random().Next(1, 100);
    }

    static int AddThread(int a, int b)
    {
        return a + b;
    }

    static int MultiplyThread(int a, int b)
    {
        return a * b;
    }
    static void CallThreadAdd()
    {
        int result = AddThread(5, 10);
        System.Console.WriteLine("Hasil jumlah: " + result);
    }
    static void CallThreadMultiply()
    {
        int result = MultiplyThread(5, 10);
        System.Console.WriteLine("Hasil kali: " + result);
    }


}