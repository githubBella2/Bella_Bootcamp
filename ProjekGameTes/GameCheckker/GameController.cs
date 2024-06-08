using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using GameCheckker.Class;
using GameCheckker.Interface;
using NLog;
using NLog.Config;

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

    public static Logger logger = LogManager.GetCurrentClassLogger();
    public int startX = 0;
    public int startY = 0;
    public int endX = 0;
    public int endY = 0;
    public int scorePlayer;
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
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Player");
        return Players;
    }
    #endregion

    public void StartGame()
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Game is start");

        #region UPDATE
        PrintListPlayer();
        #endregion


        isRunning = true;

    }
    public void SwitchPlayer()
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Time to switch player");
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
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Set Player");
        Players.Add(user1);
        Players.Add(user2);
    }

    public IPlayer GetPlayerData(IPlayer players)
    {
        return Players.Where(p => p.Username == players.Username).First<IPlayer>();
    }
    public List<IPlayer> GetPlayerData()
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Get Player");
        return this.Players;
    }
    public void PrintScore()
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Print Score Player");
        foreach (Player player in Players)
        {
            System.Console.WriteLine($"Score {player.Username}= {player.Score} ");
        }
    }

    public void CheckWinner()
    {
        foreach (Player player in Players)
        {
            scorePlayer = player.Score;
            if (player.Score >= maxScoreToWin)
            {
                LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
                logger.Info("This is log Winner");
                Console.WriteLine($"Player {player.Username} wins! with score = {player.Score}");
                isRunning = false;
                break; // Keluar dari loop foreach setelah menemukan pemenang
            }
        }
    }
    #region METHOD LIST-DITCIONARY
    public void SaveListCoordinate(Coordinate end)
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Saving list Coordinater");
        ListCoordinateMove.Add(end);
        // ListCoordinateMove.Add(y);
    }

    public List<Coordinate> GetListCoordinate()
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Get List Coordinate");
        return ListCoordinateMove;
    }

    public void SaveDataPlayerMove(IPlayer player, List<Coordinate> coordinates)
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log saving data move player");
        movePlayerDict.Add(player, coordinates);
    }

    public Dictionary<IPlayer, List<Coordinate>> GetDataPlayerMove()
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Data Player");
        return movePlayerDict;
    }

    public void SaveNewCoordinateToDict(IPlayer player, Coordinate coordinate)
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Info("Log Saving new coordinate");
        this.movePlayerDict[player].Add(coordinate);
    }
    #endregion

}
