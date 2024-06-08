using System.Reflection.Metadata;
using GameCheckker.Class;

namespace GameCheckker.Interface;

public interface IPlayer
{
    public string Username {get;}
    PieceType PieceType {get;}
    bool MakeMove(IBoard board,Coordinate start, Coordinate end);
    // bool MakeMove(Coordinate start, Coordinate end);
}
