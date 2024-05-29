using GameCheckker.Interface;

namespace GameCheckker.Class;

public class Player : IPlayer
{
    public string Username { get; private set; }
    public PieceType PieceType { get; private set; }

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

        if(board.MovePiece(startX,startY,endX,endY,PieceType)){
            return true;
        }
        else{
            System.Console.WriteLine("Invalid move");
            return false;
        }
    }
}
