using GameCheckker.Interface;

namespace GameCheckker.Class;

public class Piece : IPiece
{
    public PieceType Type { get; set; }
    public PieceState State { get; set; }
    public Piece(PieceType type)
    {
        Type = type;
        State = PieceState.Normal;
    }

    public bool Move(int startX, int startY, int endX, int endY){
        int dx = endX-startX;
        int dy = endY-startY;

        if(Math.Abs(dx) == 1 && Math.Abs(dy) ==1 ){
            return true;
        }

        if(Math.Abs(dy)==2 && Math.Abs(dy)==2){
            return true;
        }
        return false;
    }

}
