// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using GameCheckker;
using GameCheckker.Class;
using GameCheckker.Interface;

class Program
{
    public IBoard board = new Board();


    static void Main(string[] args)
    {

        // System.Console.WriteLine("Enter username for Player 1 (White): ");
        // string username1 = Console.ReadLine();
        // System.Console.WriteLine("Enter username for Player 2 (Black): ");
        // string username2 = Console.ReadLine();
        //pindah ke GC

        // GameController gameControl = new GameController(username1, username2);



        System.Console.WriteLine("Enter username for Player 1 (White): ");
        string username1 = Console.ReadLine();
        System.Console.WriteLine("Enter username for Player 2 (Black): ");
        string username2 = Console.ReadLine();
        Player _player1 = new Player(username1, PieceType.White);
        Player _player2 = new Player(username2, PieceType.Black);
        // System.Console.WriteLine($"cp {_player1.Username}");

        GameController gameControl = new GameController();
        gameControl.SetPlayerData(_player1, _player2);
        gameControl.currentPlayer = _player1;


        var printListPlayer = gameControl.PrintListPlayer();
        foreach (var people in printListPlayer)
        {
            System.Console.WriteLine($"(update) List nama: {people.Username}");
        }
        // gameControl.SwitchPlayer= SwitchPlayer();
        gameControl.StartGame();
        System.Console.WriteLine($"{gameControl.currentPlayer.Username} (Player {gameControl.currentPlayer.PieceType}), enter your move:");

        System.Console.WriteLine("Start X:");
        gameControl.startX = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Start Y:");
        gameControl.startY = int.Parse(Console.ReadLine());

        System.Console.WriteLine("End X:");
        gameControl.endX = int.Parse(Console.ReadLine());

        System.Console.WriteLine("End Y:");
        gameControl.endY = int.Parse(Console.ReadLine());

        gameControl.startCoord = new(gameControl.startX, gameControl.startY);
        gameControl.endCoord = new(gameControl.endX, gameControl.endY);

        gameControl.SaveListCoordinate(gameControl.startCoord, gameControl.endCoord);
        var getListCoordinate = gameControl.GetListCoordinate();

        var getDataPlayerMove = gameControl.GetDataPlayerMove();
        while (!gameControl.currentPlayer.MakeMove(gameControl.board, gameControl.startCoord, gameControl.endCoord))
        {
            System.Console.WriteLine("Invalid, try again");
        }
         



        // foreach (KeyValuePair<IPlayer, List<Coordinate>> item in gameControl.movePlayerDict)
        // {
        //     Console.WriteLine("=============================");
        //     var coordinates = item.Value;
        //     int numberOfPlayers = gameControl.movePlayerDict.Keys.Count;
        //     // System.Console.WriteLine(item);
        //     foreach (var kvp in gameControl.movePlayerDict)
        //     {
        //         var playerName = kvp.Key.Username.Count();
        //         var moves = kvp.Value;
        //         // Console.WriteLine($"{kvp.Key.Username}: ");

        //         foreach (var move in moves)
        //         {
        //             // Console.Clear();
        //             Console.WriteLine($"{kvp.Key.Username}: ({move.X}, {move.Y})");
        //             // Console.WriteLine($"({move.X}, {move.Y})");

        //             // if (kvp.Key.Username == currentPlayer.Username)
        //             // {
        //             //     Console.WriteLine($"({move.X}, {move.Y})");

        //             // }

        //         }
        //         System.Console.WriteLine();
        //     }
        //     System.Console.WriteLine("=============================");
        // }

    }

}