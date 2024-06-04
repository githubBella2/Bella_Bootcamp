using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using GameCheckker.Class;
using GameCheckker.Interface;

namespace GameCheckker;

public class GameController
{
    public IBoard board;
    private Board _boardClass;
    private IPlayer _player1;
    private IPlayer _player2;
    public IPlayer currentPlayer;
    public List<IPlayer> players;
    public List<Coordinate> listCoordinateMove { get; set; }
    public Dictionary<IPlayer, List<Coordinate>> movePlayerDict;
    public PieceType pieceType;
    private bool isRunning = false;


    public int startX = 0;
    public int startY = 0;
    public int endX = 0;
    public int endY = 0;
    public Coordinate startCoord;
    public Coordinate endCoord;

    private int maxScoreToWin = 3;
    // public GameController(string username1, string username2)


    public GameController()
    {
        board = new Board();
        players = new List<IPlayer>();
        listCoordinateMove = new List<Coordinate>();
        movePlayerDict = new Dictionary<IPlayer, List<Coordinate>>();
        #region LAWAS
        // _player1 = new Player(username1, PieceType.White);
        // _player2 = new  Player(username2, PieceType.Black);
        // SetPlayerData(_player1, _player2);
        // System.Console.WriteLine(GetPlayerData(_player1));
        // currentPlayer = _player1;

        //player, piecenya dimana aja dictionary. 
        // playerMoves = new Dictionary<IPlayer, List<(List<Coordinate> start, List<Coordinate> end)>>();
        #endregion
    }

    #region UPDATE Method
    public List<IPlayer> PrintListPlayer()
    {
        return players;
    }
    #endregion

    public void StartGame()
    {
        SetPlayerData(_player1, _player2);
        var printListData = GetPlayerData();
        // foreach (var item in printListData)
        // {
        //     System.Console.WriteLine("List of Player:");
        //     System.Console.WriteLine(item.Username);
        // }

        #region UPDATE
        PrintListPlayer();
        #endregion


        isRunning = true;
        while (isRunning)
        {

            board.DisplayBoard();

            // int startX = 0;
            // int startY = 0;
            // int endX = 0;
            // int endY = 0;
            // System.Console.WriteLine($"{currentPlayer.Username} (Player {currentPlayer.PieceType}), enter your move:");

            // System.Console.WriteLine("Start X:");
            // startX = int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Start Y:");
            // startY = int.Parse(Console.ReadLine());

            // System.Console.WriteLine("End X:");
            // endX = int.Parse(Console.ReadLine());

            // System.Console.WriteLine("End Y:");
            // endY = int.Parse(Console.ReadLine());

            // Coordinate startCoord = new(startX, startY);
            // Coordinate endCoord = new(endX, endY);


            // save coordinat ke list
            // SaveListCoordinate(startCoord, endCoord);
            //get coordinate list
            // var getListCoordinate = GetListCoordinate();
            // save to dictionary isinya player dan value listcoord
            // var getDataPlayerMove = GetDataPlayerMove();

            // if (!getDataPlayerMove.ContainsKey(currentPlayer)) // Periksa apakah currentPlayer belum ada dalam kamus
            // {
            //     // System.Console.WriteLine("oke");
            //     SaveDataPlayerMove(currentPlayer, getListCoordinate);
            //     // System.Console.WriteLine("oke2");

            // }
            // else if (getDataPlayerMove.ContainsKey(currentPlayer))
            // {
            //     // System.Console.WriteLine("oke3");
            //     Coordinate coordinateNew = new(endX, endY);
            //     SaveNewCoordinateToDict(currentPlayer, coordinateNew);
            //     // System.Console.WriteLine("oke4");
            // }

            // Console.Clear();
            // foreach (KeyValuePair<IPlayer, List<Coordinate>> item in getDataPlayerMove)
            // {
            //     Trace.WriteLine("=============================");
            //     var coordinates = item.Value;
            //     int numberOfPlayers = getDataPlayerMove.Keys.Count;
            //     // System.Console.WriteLine(item);
            //     foreach (var kvp in getDataPlayerMove)
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



            // while (!currentPlayer.MakeMove(board, startCoord, endCoord))
            // {
            //     System.Console.WriteLine("Invalid, try again");
            // }



            SwitchPlayer();
            PrintScore();
            CheckWinner();
        }
    }
    private void SwitchPlayer()
    {
        if (currentPlayer == _player1)
        {
            currentPlayer = _player2;
            // System.Console.WriteLine(currentPlayer);
        }
        else
        {
            currentPlayer = _player1;
            // System.Console.WriteLine(currentPlayer);

        }
        // System.Console.WriteLine(currentPlayer);
        // return currentPlayer;
    }


    public void SetPlayerData(IPlayer user1, IPlayer user2)
    {
        this.players.Add(user1);
        this.players.Add(user2);
    }

    public IPlayer GetPlayerData(IPlayer players)
    {
        return this.players.Where(p => p.Username == players.Username).First<IPlayer>();
    }
    public List<IPlayer> GetPlayerData()
    {
        return this.players;
    }
    public void PrintScore()
    {
        foreach (Player player in players)
        {
            System.Console.WriteLine($"Score {player.Username}= {player.Score} ");
        }
    }

    public void CheckWinner()
    {

        foreach (Player player in players)
        {
            if (player.Score >= maxScoreToWin)
            {
                Console.WriteLine($"Player {player.Username} wins! with score = {player.Score}");
                isRunning = false;
                break; // Keluar dari loop foreach setelah menemukan pemenang
            }
        }
    }
    #region METHOD LIST-DITCIONARY
    public void SaveListCoordinate(Coordinate x, Coordinate y)
    {
        listCoordinateMove.Add(x);
        listCoordinateMove.Add(y);
    }

    public List<Coordinate> GetListCoordinate()
    {
        return listCoordinateMove;
    }

    public void SaveDataPlayerMove(IPlayer player, List<Coordinate> coordinates)
    {
        movePlayerDict.Add(player, coordinates);
    }

    public Dictionary<IPlayer, List<Coordinate>> GetDataPlayerMove()
    {
        return movePlayerDict;
    }

    public void SaveNewCoordinateToDict(IPlayer player, Coordinate coordinate)
    {
        this.movePlayerDict[player].Add(coordinate);
    }


    #endregion



}
