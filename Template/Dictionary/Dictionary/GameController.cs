namespace Dictionary;

public class GameController
{
    public List<IPlayer> players;
    public List<Coordinate> coordinatesHistory {get;set;}
    public Dictionary<IPlayer, List<Coordinate>> FLMX ;
    public GameController(){
        this.players = new List<IPlayer>();
        this.coordinatesHistory = new List<Coordinate>();
        this.FLMX = new Dictionary<IPlayer, List<Coordinate>>();
    }

    public void GameStart(){
        Player player1 = new("Fausta");
        Player player2 = new("AbandonedMutexException");
        Coordinate player1coord1 = new(1,2);
        Coordinate player1coord2 = new(2,3);

        // Console.WriteLine(player1coord1.X);
        
        SaveListPlayers(player1, player2);
        SaveListCoordinate(player1coord1, player1coord2);

        var item = GetCoordinates();
        SaveToDict(player1,item);
        //SaveToDict(player1,player1coord2);

        Coordinate player2coord1 = new(4,2);
        Coordinate player2coord2 = new(2,6);

        SaveListCoordinate(player2coord1, player2coord2);

        var item2 = GetCoordinates();
        SaveToDict(player2,item2);

        //SaveToDict(player2,player2coord1);
        //SaveToDict(player2,player2coord2);
    }

    public void SaveListPlayers(IPlayer player1, IPlayer player2){
        this.players.Add(player1);
        this.players.Add(player2);
    }
    public List<IPlayer> GetListPlayers(){
        return this.players;
    }
    public IPlayer GetAPlayer(string player){
        return this.players.Where(p => p.UserName == player).First<IPlayer>();
    }

    public void SaveListCoordinate(Coordinate coordinate1, Coordinate coordinate2){
        this.coordinatesHistory.Add(coordinate1);
        this.coordinatesHistory.Add(coordinate2);
    }

    public List<Coordinate> GetCoordinates(){
        return this.coordinatesHistory;
    }
    public void SaveToDict(IPlayer player, List<Coordinate> coordinate){
        this.FLMX.Add(player,coordinate);
    }

    public void SaveNewCoordinateToDict(IPlayer player, Coordinate coordinate){
        this.FLMX[player].Add(coordinate);
    }

    public Dictionary<IPlayer,List<Coordinate>> GetaToDict(){
        return this.FLMX;
    }

    public void GameProces(){

        // SaveListCoordinate(new Coordinate(4,2), new Coordinate(10,12));
        Coordinate player2coord3 = new(12,10);
        var player2 = GetAPlayer("AbandonedMutexException");
        SaveNewCoordinateToDict(player2,player2coord3);

        

        
    }
}
