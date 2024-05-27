// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Drawing;
using TugasThread;

class Program
{
    static int point = 0;
    static bool running = true;
    static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    static void Main(string[] args)
    // static async Task Main(string[] args)

    {
        #region  LOCK
        Thread player1 = new Thread(() => Player.PlayerHits("Alex", 100));
        Thread player2 = new Thread(() => Player.PlayerHits("Bella", 160));

        player1.Start();
        player2.Start();

        player1.Join();
        player2.Join();
        System.Console.WriteLine("Game Over");
        #endregion


        // System.Console.WriteLine("Make your username:");
        // string userPlayer = Console.ReadLine();
        // if (userPlayer == null)
        // {
        //     System.Console.WriteLine("Please enter valid uname");
        // }

        #region  BACKGROUND
        // Thread backgroundThread = new Thread(Player.CalculatePoinBackground);
        // backgroundThread.IsBackground = true;
        // backgroundThread.Start();

        // while (running)
        // {
        //     System.Console.WriteLine("Press q to quit");
        //     string input = Console.ReadLine();
        //     if (input == "q")
        //     {
        //         running = false;
        //         break;
        //     }
        // }
        #endregion


        #region FOREGROUND
        // Thread foregroundThread = new Thread(()=>Player.CalculatePoinForeground(cancellationTokenSource.Token));
        // foregroundThread.IsBackground = false;
        // foregroundThread.Start();

        // while (true)
        // {
        //     System.Console.WriteLine("Press q to quit");
        //     string input = Console.ReadLine();
        //     if (input == "q")
        //     {
        //         running = false;
        //         break;
        //     }
        //     //memastikan foreground stop dengan baik
        //     foregroundThread.Join();
        //     System.Console.WriteLine($"Game over, {userPlayer}. Final points: {point} ");
        // }
        // }
        #endregion


        #region TASK
        // var poinTask = Task.Run(() => Player.CalculatePoinTask(cancellationTokenSource.Token));
        // while (true)
        // {
        //     Console.WriteLine("Press 'q' to quit the game.");
        //     string input = Console.ReadLine();
        //     if (input == "q")
        //     {
        //         cancellationTokenSource.Cancel();
        //         break;
        //     }
        // }
        // await poinTask;
        // Console.WriteLine($"Game over, {userPlayer}. Final points: {point}");
        #endregion


    }

}