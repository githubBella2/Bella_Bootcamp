namespace Lock;

public class Player
{
    static object localObject = new object();
    private Dictionary<Player,int> _playerScore = new Dictionary<Player, int>();
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
    public static int HitungPoinTask(int poinLama)
    {
        // Task.Delay(2000).Wait();
        // await Task.Delay(2000);
        return 200 + poinLama;
    }

    public static int CalculatePoin(int poinLama)
    {
        return 100 + poinLama;
    }
    public static void CallThreadCalculatePoin()
    {
        int poin = 90;
        int result = CalculatePoin(poin);
        System.Console.WriteLine("Hasil kali: " + result);
    }
    public static int CalculatePoin2(int poinLama)
    {
        return 100 + poinLama;
    }

    public static void MultiplyScore(Program program, Player player, int score){
        if(Monitor.TryEnter(localObject)){
            try{
            System.Console.WriteLine("Multiply score is" +(player._playerScore[player] * 10));

            }
            finally{
                Monitor.Exit(localObject);
            }
        }
    }


}
