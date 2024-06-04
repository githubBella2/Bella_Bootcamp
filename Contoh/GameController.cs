using System.Collections;

namespace Contoh;

public class GameController
{
    private List<IPlayer> _playerList = new();


    private Dictionary<IPlayer, List<ICard>> _playerData;

    public GameController()
    {
        _playerData = new Dictionary<IPlayer, List<ICard>>();
    }

    Dictionary<IPlayer, List<ICard>> playerCards;
    // Dictionary<IPlayer, List<ICard>> playerCards = new();

    public void SetPlayer(IPlayer player)
    {
        _playerList.Add(player);
    }
    private void SetAllPlayer(List<IPlayer> p)
    {
        _playerList.AddRange(p);
    }
    // public void GetPossibleCard(IPlayer p){// nge print kartu yg possible untuk player
    public List<ICard> GetPossibleCard(IPlayer p)
    {// nge print kartu yg possible untuk player
        // foreach (ICard card in players[p])
        // {
        //     System.Console.WriteLine(card);
        // }

        return _playerData[p].ToList() ;
        // return playerCards[p] ;
        //TIDAK ADA PRINT, tp return, dan void diagnti tipe data
    }

    public void SetPlayerCard(IPlayer player, List<ICard> cards)
    {
        _playerData.Add(player, cards);
    }

    #region JUN
    public void AddPlayerCardData(IPlayer player, List<ICard> data)
    {
        _playerData.Add(player, data);
        
    }
    #endregion
}
