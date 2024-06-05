using GameCheckker.Class;

namespace GameCheckker.Interface;

public interface IPiece
{
    PieceType Type {get;set;}
    PieceState State {get;set;}
    bool Move(int startX,int startY, int endX, int endY);
}
