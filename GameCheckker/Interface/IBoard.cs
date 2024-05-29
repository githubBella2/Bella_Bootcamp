using GameCheckker.Class;

namespace GameCheckker.Interface;

public interface IBoard
{
    void DisplayBoard();
    bool MovePiece(int startX, int startY, int endX, int endY,PieceType pieceType);
}
