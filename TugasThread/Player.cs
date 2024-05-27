namespace TugasThread;

public class Player
{
    static object lockObject = new object();
    private string _username;
    public string Username
    {
        get
        {
            return _username;
        }
        set
        {
            _username = value;
        }
    }
    public Player(string username)
    {
        Username = username;
    }

    public static void CalculatePoinBackground()
    {
        bool running = true;
        int point = 0;
        while (running)
        {
            Thread.Sleep(2000);
            point++;
            System.Console.WriteLine($"Points: {point}");
        }
    }

    public static void CalculatePoinForeground(CancellationToken token)
    {
        bool running = true;
        int point = 0;
        // while (running)
        while (!token.IsCancellationRequested)
        {
            Thread.Sleep(1000);
            point++;
            System.Console.WriteLine($"Points foregr: {point}");
        }
        Console.WriteLine("Foreground thread was cancelled.");
    }

    public static async Task CalculatePoinTask(CancellationToken token)
    {
        bool running = true;
        int point = 0;


        try
        {
            while (running)
            {
                await Task.Delay(1000, token);
                point++;
                System.Console.WriteLine($"Points Task: {point}");

            }
        }
        catch (OperationCanceledException)
        {

            Console.WriteLine("Points calculation was cancelled.");
        }
    }

    public static void PlayerHits(string username, int healthPlayer)
    {
        int nyawa = healthPlayer;
        for (int i = 0; i < 10; i++)
        {
            lock (lockObject)
            {
                System.Console.WriteLine($"{username} sedang memukul !!");
                nyawa -= 1;
                System.Console.WriteLine($"{username} nyawa: {nyawa}");
            }
            Thread.Sleep(1000);
        }
    }

}
