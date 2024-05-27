// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Lock;

public class Program
{
    static object lockObject = new object();
    private Dictionary<Player, int> _playerScore = new Dictionary<Player, int>();

    static void Main(string[] args)
    // static async Task Main(string[] args)

    {
        // Thread one = new Thread(PrintChart);
        // Thread two = new Thread(PrintChart);
        // one.Start();
        // two.Start();

        Console.Write("Masukkan Username");
        string username = Console.ReadLine();
        if (username != null)
        {
            Player player = new Player(username);
            System.Console.WriteLine("Username Anda:" + player.Username);
            Program program = new();
            // Task.Run(() => )
            Thread th1 = new Thread(() => Player.CallThreadCalculatePoin());
            th1.Start();

            Thread perkalianScore = new Thread(() => Player.MultiplyScore(program, player, 4));
            perkalianScore.Start();
        }
        else
        {
            System.Console.WriteLine("Masukkan username !");
        }




    }
    static void PrintChart()
    {
        lock (lockObject)
        {
            string strArray = "Hi programmer";
            int y = 0;
            for (y = y; y < strArray.Length; y++)
            {
                Console.Write($"{strArray[y]}");
                Thread.Sleep(TimeSpan.FromSeconds(0.1));
            }
            Console.WriteLine(" ");// kebawah = \n
        }
    }
}

// https://www.webscale.com/engineering-education/using-c-to-demonstrate-lock-in-thread/#:~:text=Visual%20Studio%20installed.-,C%23%20lock%20in%20thread,code%20while%20another%20does%20so.

// Ega Oktabrianto
// 10.26
// https://docs.google.com/document/d/1ixpv-tmbASxMca_AbatFvQ5L8t9JNpP4vPHYiDBKpig/edit?usp=sharing

// game sederhana, misal ada tampilan hitung poin, menampilkan GUI.
// user bisa masukin nama, multi threading