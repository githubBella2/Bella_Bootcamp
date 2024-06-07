using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using GameCheckker.Class;
using GameCheckker.Interface;

namespace GameCheckker;

public class GameController
{
    public IBoard board;
    public IPlayer CurrentPlayer { get; set; }
    public List<IPlayer> Players { get; set; }
    public List<Coordinate> ListCoordinateMove { get; set; }
    public Dictionary<IPlayer, List<Coordinate>> movePlayerDict;
    public PieceType pieceType;
    public bool isRunning = false;


    public int startX = 0;
    public int startY = 0;
    public int endX = 0;
    public int endY = 0;

    public void SetStart(int x, int y)
    {
        startX = x;
        startY = y;
    }
    public void SetEnd(int x, int y)
    {
        endX = x;
        endY = y;
    }
    public Coordinate startCoord;
    public Coordinate endCoord;
    private int maxScoreToWin = 3;

    public GameController()
    {
        board = new Board();
        Players = new List<IPlayer>();
        ListCoordinateMove = new List<Coordinate>();
        movePlayerDict = new Dictionary<IPlayer, List<Coordinate>>();
    }

    #region UPDATE Method
    public List<IPlayer> PrintListPlayer()
    {
        return Players;
    }
    #endregion

    public void StartGame()
    {
        #region UPDATE
        PrintListPlayer();
        #endregion


        isRunning = true;

    }
    public void SwitchPlayer()
    {
        if (CurrentPlayer == Players[0])
        {
            CurrentPlayer = Players[1];
        }
        else
        {
            CurrentPlayer = Players[0];

        }

    }


    public void SetPlayerData(IPlayer user1, IPlayer user2)
    {
        Players.Add(user1);
        Players.Add(user2);
    }

    public IPlayer GetPlayerData(IPlayer players)
    {
        return Players.Where(p => p.Username == players.Username).First<IPlayer>();
    }
    public List<IPlayer> GetPlayerData()
    {
        return this.Players;
    }
    public void PrintScore()
    {
        foreach (Player player in Players)
        {
            System.Console.WriteLine($"Score {player.Username}= {player.Score} ");
        }
    }

    public void CheckWinner()
    {

        foreach (Player player in Players)
        {
            if (player.Score >= maxScoreToWin)
            {
                Console.WriteLine($"Player {player.Username} wins! with score = {player.Score}");
                isRunning = false;
                break; // Keluar dari loop foreach setelah menemukan pemenang
            }
        }
    }
    #region METHOD LIST-DITCIONARY
    public void SaveListCoordinate(Coordinate end)
    {
        ListCoordinateMove.Add(end);
        // ListCoordinateMove.Add(y);
    }

    public List<Coordinate> GetListCoordinate()
    {
        return ListCoordinateMove;
    }

    public void SaveDataPlayerMove(IPlayer player, List<Coordinate> coordinates)
    {
        movePlayerDict.Add(player, coordinates);
    }

    public Dictionary<IPlayer, List<Coordinate>> GetDataPlayerMove()
    {
        return movePlayerDict;
    }

    public void SaveNewCoordinateToDict(IPlayer player, Coordinate coordinate)
    {
        this.movePlayerDict[player].Add(coordinate);
    }
    #endregion

}
