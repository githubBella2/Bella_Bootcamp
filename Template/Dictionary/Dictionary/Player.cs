namespace Dictionary;

public class Player:IPlayer
{
    public string UserName{get;set;}
    public Player(string UserName){
        this.UserName = UserName;
    }
}
