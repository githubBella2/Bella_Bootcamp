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
