using GameCheckker.Class;
using GameCheckker.Interface;

namespace GameCheckker;

public class GameController
{
    private IBoard board;
    private IPlayer player1;
    private IPlayer player2;
    private IPlayer currentPlayer;

    public GameController(string username1, string username2)
    {
        board = new Board();
        player1 = new Player(username1, PieceType.White);
        player2 = new Player(username2, PieceType.Black);
        currentPlayer = player1;

    }

    public void StartGame(){
        while(true){
            Console.Clear();
            board.DisplayBoard();
    
            while(!currentPlayer.MakeMove(board)){
                System.Console.WriteLine("Invalid, try again");
            }
            SwitchPlayer();
        }
    }

    private void SwitchPlayer()
    {
        currentPlayer = currentPlayer == player1 ? player2 : player1;
    }
}
