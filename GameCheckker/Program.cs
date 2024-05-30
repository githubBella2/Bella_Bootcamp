// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using GameCheckker;
using GameCheckker.Class;
using GameCheckker.Interface;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter username for Player 1 (White): ");
        string username1 = Console.ReadLine();
        System.Console.WriteLine("Enter username for Player 2 (Black): ");
        string username2 = Console.ReadLine();
        Board board = new();
        GameController gameControl = new GameController(username1, username2);
        gameControl.StartGame();
        // gameControl.SwitchPlayer= SwitchPlayer();
    }
    
}