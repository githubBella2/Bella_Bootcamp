namespace Checkker.Test;
using GameCheckker;
using GameCheckker.Class;
using GameCheckker.Interface;

public class Tests
{
    private GameController _gc;
    [SetUp]
    public void Setup()
    {
        _gc = new GameController();
    }

    [Test]
    public void SwitchPlayer_ReturnPlayer(){
        // Arrange
        IPlayer user1 = new Player("Bambang");
        IPlayer user2 = new Player("Deni");
        IPlayer expect = user2;
        _gc.SetPlayerData(user1,user2);
        _gc.CurrentPlayer=user1;

        // action
        _gc.SwitchPlayer();
        var result = _gc.CurrentPlayer.Username;

        // ASSERT
        Assert.AreEqual(expect.Username,result);
    }
}