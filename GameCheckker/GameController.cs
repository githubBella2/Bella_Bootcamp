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
    List<IPlayer> players;
    public List<Coordinate> listCoordinateMove;
    public Dictionary<IPlayer, List<Coordinate>> movePlayer;
    public PieceType pieceType;


    // public GameController(string username1, string username2)
    public GameController()
    {
        board = new Board();
        players = new List<IPlayer>();

        StartGame();

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

    public void StartGame()
    {
        System.Console.WriteLine("Enter username for Player 1 (White): ");
        string username1 = Console.ReadLine();
        System.Console.WriteLine("Enter username for Player 2 (Black): ");
        string username2 = Console.ReadLine();
        _player1 = new Player(username1, PieceType.White);
        _player2 = new Player(username2, PieceType.Black);
        currentPlayer = _player1;

        SetPlayerData(_player1, _player2);
        var printListData = GetPlayerData();
        foreach (var item in printListData)
        {
            System.Console.WriteLine("List of Player:");
            System.Console.WriteLine(item.Username);
        }
        // ----------------------------------------
        // getdata dictionary
        // var dataMovePlayer = _boardClass.GetDataPlayerMove();
        // // printout data movenya
        // foreach (KeyValuePair<IPlayer, List<Coordinate>> item in dataMovePlayer)
        // {
        //     var coordinate = item.Value;
        //     foreach (var i in coordinate)
        //     {
        //         System.Console.WriteLine($"{item.Key}: ({i.X}, {i.Y}) ");

        //     }
        // }
        // System.Console.WriteLine($"List {GetPlayerData(_player1).Username} ");
        // while (true)
        // {
            
            board.DisplayBoard();

            System.Console.WriteLine($"{currentPlayer.Username} (Player {currentPlayer.PieceType}), enter your move:");

            System.Console.WriteLine("Start X:");
            int startX = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Start Y:");
            int startY = int.Parse(Console.ReadLine());

            System.Console.WriteLine("End X:");
            int endX = int.Parse(Console.ReadLine());

            System.Console.WriteLine("End Y:");
            int endY = int.Parse(Console.ReadLine());

            Coordinate start = new Coordinate(startX, startY);
            Coordinate end = new Coordinate(endX, endY);

        // save coordinat ke list
        SaveListCoordinate(start, end);
        //get coordinate list
        var getListCoordinate = GetListCoordinate();
        // save to dictionary isinya player dan value listcoord
        SaveDataPlayerMove(currentPlayer, getListCoordinate);
        var getDataPlayerMove = GetDataPlayerMove();
        foreach (KeyValuePair<IPlayer,List<Coordinate>> item in getDataPlayerMove )
        {
            var valueCoord=item.Value;
            foreach(var c in valueCoord){
                System.Console.WriteLine($"{item.Key}: ({c.X}, {c.Y})");
            }
        }

            while (!currentPlayer.MakeMove(board, start,end))
            {
                System.Console.WriteLine("Invalid, try again");
            }
            SwitchPlayer();
        // }
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
        movePlayer.Add(player, listCoordinateMove);
    }

    public Dictionary<IPlayer, List<Coordinate>> GetDataPlayerMove()
    {
        return movePlayer;
    }
    #endregion



}
