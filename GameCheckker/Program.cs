// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using GameCheckker;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter username for Player 1 (White): ");
        string username1 = Console.ReadLine();
        System.Console.WriteLine("Enter username for Player 2 (Black): ");
        string username2 = Console.ReadLine();

        GameController gameControl = new GameController(username1, username2);
        gameControl.StartGame();
    }
}