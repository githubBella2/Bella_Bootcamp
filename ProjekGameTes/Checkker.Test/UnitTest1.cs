namespace Checkker.Test;
using GameCheckker;
using GameCheckker.Class;
using GameCheckker.Interface;

public class Tests
{
    private GameController _gc;
    private Player _player;
    [SetUp]
    public void Setup()
    {
        _gc = new GameController();
        _player = new("");
    }

    [Test]
    public void SwitchPlayer_ReturnPlayer()
    {
        // Arrange
        IPlayer user1 = new Player("Bambang");
        IPlayer user2 = new Player("Deni");
        IPlayer expect = user2;
        _gc.SetPlayerData(user1, user2);
        _gc.CurrentPlayer = user1;

        // action
        _gc.SwitchPlayer();
        var result = _gc.CurrentPlayer.Username;

        // ASSERT
        Assert.AreEqual(expect.Username, result);
    }
    [Test]
    public void CheckWinner_ReturnWinner()
    // Arrange
    {
        Player user1 = new Player("Bambang");
        Player user2 = new Player("Deni");
        user1.Score = 1;
        user2.Score = 3;
        _gc.scorePlayer = user2.Score;

        // _action
        _gc.CheckWinner();
        var result = _gc.scorePlayer;

        // Assert
        Assert.AreEqual(user2.Score, result);

    }
    [Test]
    public void SaveListCoordinate_ReturnVoid()
    {
        // Arrange
        Coordinate end = new Coordinate(2, 3);
        _gc.ListCoordinateMove.Add(end);

        // _action
        _gc.SaveListCoordinate(end);
        var result = _gc.ListCoordinateMove;

        // Assert
        Assert.AreEqual(_gc.ListCoordinateMove, result);

    }

    [Test]
    public void AddPoin_ReturnVoid()
    {
        // Arrange
        int poin = 1;
        int expectPoin = 1;

        //action
        _player.AddScore(1);
        var res = _player.Score;

        // Assert
        Assert.AreEqual(expectPoin, res);

    }

    



}