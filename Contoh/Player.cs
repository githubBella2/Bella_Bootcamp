namespace Contoh;

public class Player : IPlayer
{
    public string PlayerName { get; private set; }

    public Player(string name)
    {
        PlayerName = name;
    }
}
