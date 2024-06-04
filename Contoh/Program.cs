// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Contoh;

class Program
{
    static void Main(string[] args)
    {
        GameController gc = new();
        #region Fadil
        // // gc.SetPlayer(new Player("Jojo"));
        // // Player player = new("Jojo");
        // Player player = new("Jojo");
        // gc.SetPlayer(player);
        // Card card1 = new("Magic");
        // Card card2 = new("Spell");
        // List<ICard> cards = new(){
        //     card1,card2
        // };

        // gc.SetPlayerCard(player, cards);
        // // gc.SetPlayerCard.(player, new List<Card>(new Card("a"), new Card("b")));
        // List<ICard>  carding = gc.GetPossibleCard(player);
        // foreach (Card kartu in carding)
        // {
        //     System.Console.WriteLine(kartu.CardName);
        // }
        // // gc.GetPossibleCard(player);
        // System.Console.WriteLine();
        #endregion

        #region JUN
        IPlayer playerA = new Player("Gugu");
        ICard cardA = new Card("Solo");
        ICard cardB = new Card("Jogja");

        IPlayer playerB = new Player("");
        ICard cardC = new Card("Manchester");
        ICard cardD = new Card("United");

        GameController gc2 = new();
        gc2.AddPlayerCardData(playerA, new List<ICard> { cardA, cardB });
        gc2.AddPlayerCardData(playerB, new List<ICard> { cardC, cardD });

        List<ICard> cardListPos = gc2.GetPossibleCard(playerA);
        foreach (var card in cardListPos)
        {
            card.GetInfo();
        }

        foreach (var card in gc2.GetPossibleCard(playerB))
        {
            card.GetInfo();
        }
        #endregion

    }
}