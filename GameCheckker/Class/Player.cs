using GameCheckker.Interface;

namespace GameCheckker.Class;

public class Player : IPlayer
{
    public string Username { get; private set; }
    public PieceType PieceType { get; private set; }
    public int Score { get; private set; }
    public Player(string username, PieceType pieceType)
    {
        Username = username;
        PieceType = pieceType;
        Score = 0;
    }
    public Player(string username)
    {
        Username = username;
    }

    public bool MakeMove(IBoard board, Coordinate start, Coordinate end)
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



        if (board.MovePiece(start, end, PieceType,this))
        {
            return true;
        }
        else
        {
            System.Console.WriteLine("Invalid move");
            return false;
        }
    }

    public void AddScore(int poin)
    {
        Score += poin;
    }


}
