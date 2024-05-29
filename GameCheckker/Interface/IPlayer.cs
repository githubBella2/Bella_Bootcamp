using System.Reflection.Metadata;
using GameCheckker.Class;

namespace GameCheckker.Interface;

public interface IPlayer
{
    string Username {get;}
    PieceType PieceType {get;}
    bool MakeMove(IBoard board);
}
