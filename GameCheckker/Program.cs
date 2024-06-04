// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Text;
using GameCheckker;
using GameCheckker.Class;
using GameCheckker.Interface;

class Program
{
    public IBoard board = new Board();


    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter username for Player 1 (White): ");
        string username1 = Console.ReadLine();
        System.Console.WriteLine("Enter username for Player 2 (Black): ");
        string username2 = Console.ReadLine();
        Player _player1 = new Player(username1, PieceType.White);
        Player _player2 = new Player(username2, PieceType.Black);

        GameController gameControl = new GameController();
        gameControl.SetPlayerData(_player1, _player2);

        gameControl.CurrentPlayer = _player1;


        var printListPlayer = gameControl.PrintListPlayer();
        foreach (var people in printListPlayer)
        {
            System.Console.WriteLine($"(update) List nama: {people.Username}");
        }
        gameControl.StartGame();
        while (gameControl.isRunning)
        {
            gameControl.board.DisplayBoard();
            System.Console.WriteLine($"{gameControl.CurrentPlayer.Username} (Player {gameControl.CurrentPlayer.PieceType}), enter your move:");

            System.Console.WriteLine("Start X:");
            int startx = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Start Y:");
            int startY = int.Parse(Console.ReadLine());
            gameControl.SetStart(startx, startY);

            System.Console.WriteLine("End X:");
            int endx = int.Parse(Console.ReadLine());

            System.Console.WriteLine("End Y:");
            int endy = int.Parse(Console.ReadLine());
            gameControl.SetEnd(endx, endy);

            gameControl.startCoord = new(gameControl.startX, gameControl.startY);
            gameControl.endCoord = new(gameControl.endX, gameControl.endY);

            // save coordinat ke list
            gameControl.SaveListCoordinate(gameControl.endCoord);
            //get coordinate list
            var getListCoordinate = gameControl.GetListCoordinate();
            //save to dictionary isinya player dan value listcoord
            var getDataPlayerMove = gameControl.GetDataPlayerMove();

            if (!getDataPlayerMove.ContainsKey(gameControl.CurrentPlayer)) // Periksa apakah CurrentPlayer belum ada dalam kamus
            {
                gameControl.SaveDataPlayerMove(gameControl.CurrentPlayer, new List<Coordinate> { gameControl.endCoord });

            }
            else if (getDataPlayerMove.ContainsKey(gameControl.CurrentPlayer))
            {
                Coordinate coordinateNew = new(endx, endy);
                gameControl.SaveNewCoordinateToDict(gameControl.CurrentPlayer, coordinateNew);
            }
            // print Dictionary moveplayer

            // foreach (var pair in getDataPlayerMove)
            // {
            //     var cp = gameControl.CurrentPlayer;
            //    System.Console.WriteLine($"");
            //     if (getDataPlayerMove.ContainsKey())
            //     {
            //         Console.WriteLine($"Key {keyToPrint} punya:");
            //         foreach (var tuple in data[keyToPrint])
            //         {
            //             Console.WriteLine(tuple);
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Key {keyToPrint} tidak ditemukan dalam dictionary.");
            //     }


            // }
            foreach (KeyValuePair<IPlayer, List<Coordinate>> item in getDataPlayerMove)
            {
                Console.WriteLine("=============================");
                var coordinates = item.Value;
                int numberOfPlayers = getDataPlayerMove.Keys.Count;
                // System.Console.WriteLine(item);
                foreach (var kvp in getDataPlayerMove)
                {
                    var playerName = kvp.Key.Username.Count();
                    var moves = kvp.Value;
                    Console.WriteLine($"{kvp.Key.Username}: ");
                    StringBuilder teksmove = new StringBuilder();
                    foreach (var i in moves)
                    {
                        teksmove.Append($" ({i.X}, {i.Y}) ");
                        // Console.WriteLine($" ({i.X}, {i.Y})");

                    }
                    System.Console.WriteLine(teksmove.ToString());
                    System.Console.WriteLine();
                }
                System.Console.WriteLine("=============================");
            }


            while (!gameControl.CurrentPlayer.MakeMove(gameControl.board, gameControl.startCoord, gameControl.endCoord))
            {
                System.Console.WriteLine("Invalid, try again");
                break;
            }
            gameControl.SwitchPlayer(gameControl.CurrentPlayer);
            gameControl.PrintScore();
            gameControl.CheckWinner();
        }

    }

}