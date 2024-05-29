namespace DataContractDemo;

public class Player2 : IPlayer
{
    public int Id { get; private set; }
    public string Name { get; }
    public void AddPlayer()
    {
        System.Console.WriteLine("INI INTERFACE");
    }
}
