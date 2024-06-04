namespace Contoh;

public class Card:ICard
{
    public string CardName{get;private set;}

    public Card (string cardName){
        CardName=cardName;
    }

    public void GetInfo(){
        System.Console.WriteLine($"Card Name: {CardName}");
    }
}
