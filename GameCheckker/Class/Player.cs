using GameCheckker.Interface;

namespace GameCheckker.Class;

public class Player : IPlayer
{
    public string Username { get; private set; }
    public PieceType PieceType { get; private set; }
    List<Coordinate> start;
    List<Coordinate> end;
    
    public List<Coordinate> listCoordinateMove;
    public Dictionary<IPlayer, List<Coordinate>> movePlayer;
    public Player(string username, PieceType pieceType)
    {
        Username = username;
        PieceType = pieceType;
    }

    public bool MakeMove(IBoard board,Coordinate start, Coordinate end)
    {
        // System.Console.WriteLine($"{Username} (Player {PieceType}), enter your move:");

        // System.Console.WriteLine("Start X:");
        // int startX = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Start Y:");
        // int startY = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("End X:");
        // int endX = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("End Y:");
        // int endY = int.Parse(Console.ReadLine());

        // Coordinate start = new Coordinate(startX, startY);
        // Coordinate end = new Coordinate(endX, endY);
       


        if (board.MovePiece(start, end, PieceType))
        {
            return true;
        }
        else
        {
            System.Console.WriteLine("Invalid move");
            return false;
        }
    }


}
