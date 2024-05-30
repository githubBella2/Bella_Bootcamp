using GameCheckker.Interface;

namespace GameCheckker.Class;

public class Player : IPlayer
{
    public string Username { get; private set; }
    public PieceType PieceType { get; private set; }
    // public Position position{get;private set;}
    // public Dictionary<IPlayer, IPiece> pointPlayer = new Dictionary<IPlayer, IPiece>();

    // public Dictionary<string, List<int>> moveCoordinate = new Dictionary<string, List<int>>();

    // public Dictionary<string, Position> positionsPlayer = new Dictionary<string, Position>();
    List<Coordinate> start;
    List<Coordinate> end;

    public Player(string username, PieceType pieceType)
    {
        Username = username;
        PieceType = pieceType;
    }

    public bool MakeMove(IBoard board)
    {
        System.Console.WriteLine($"{Username} (Player {PieceType}), enter your move:");

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

        if (board.MovePiece(start,end, PieceType))
        // if (board.MovePiece( start, end, PieceType, Username))
        {
            // moveCoordinate.Add(Username, new List<int> { endX, endY });
            // foreach (var item in moveCoordinate)
            // {
            //     System.Console.WriteLine($"Langkah {Username}: {item.Value[0]},{item.Value[1]}");

            // }
            return true;
        }
        else
        {
            System.Console.WriteLine("Invalid move");
            return false;
        }
    }

    // public void  AddPointPlayer(){

    // }

}
