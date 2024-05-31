using GameCheckker.Class;

namespace GameCheckker.Interface;

public interface IBoard
{
    void DisplayBoard();
    bool MovePiece(Coordinate start, Coordinate end, PieceType pieceType);
    // bool MovePiece(Coordinate start, Coordinate end, PieceType pieceType,IPlayer username);
    // bool MovePiece(List<int> start,List<int> end, PieceType pieceType, string username);
    // bool MovePiece(List<Coordinate> start,List<Coordinate> end, PieceType pieceType, string username);
    // bool MovePiece(List<Coordinate> start,List<Coordinate> end, PieceType pieceType, IPlayer username);
    
}
