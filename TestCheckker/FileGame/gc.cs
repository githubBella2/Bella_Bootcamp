// using System.Security.Cryptography.X509Certificates;
// using GameCheckker.Class;
// using GameCheckker.Interface;

// namespace GameCheckker;

// public class GameController
// {
//     private IBoard _board;
//     private IPlayer _player1;
//     private IPlayer _player2;
//     private IPlayer _currentPlayer;
//     // Action<int, int> Addition2 = AddNumbers2;
//     //     Addition2(2, 3);
//     private Dictionary<string, List<(List<int> start, List<int> end)>> playerMove;
//     private Dictionary<IPlayer, List<(List<Coordinate> start, List<Coordinate> end)>> playerMoves;

//     public GameController(string username1, string username2)
//     {
//         _board = new Board();
//         _player1 = new Player(username1, PieceType.White);
//         _player2 = new Player(username2, PieceType.Black);
//         _currentPlayer = _player1;

//         //player, piecenya dimana aja dictionary. 
//         // playerMoves = new Dictionary<IPlayer, List<(List<Coordinate> start, List<Coordinate> end)>>();
//     }

//     public void StartGame()
//     {
//         while (true)
//         {
//             // Console.Clear();
//             _board.DisplayBoard();

//             while (!_currentPlayer.MakeMove(_board))
//             {
//                 System.Console.WriteLine("Invalid, try again");
//             }
//             SwitchPlayer();
//             // Func<int, int, int> addFunc = (x, y) => x + y;
//             // Action<IPlayer>? SwitchPlayer;
//             // Func<IPlayer, IPlayer> DecidePlayer = SwitchPlayer;
//             // DecidePlayer(_currentPlayer);

//         }
//     }

//     // public void SwitchPlayer(IPlayer _currentPlayer)
//     private void SwitchPlayer()
//     {
//         if (_currentPlayer == _player1)
//         {
//             _currentPlayer = _player2;
//             // System.Console.WriteLine(_currentPlayer);
//         }
//         else
//         {
//             _currentPlayer = _player1;
//             // System.Console.WriteLine(_currentPlayer);

//         }
//         // System.Console.WriteLine(_currentPlayer);
//         // return _currentPlayer;
//     }


//     // public void RecordMove(IPlayer playerName, List<Coordinate> start, List<Coordinate> end)
//     // {
//     //     if (!playerMoves.ContainsKey(playerName))
//     //     {
//     //         playerMoves[playerName] = new List<(List<Coordinate> start, List<Coordinate> end)>();
//     //     }
//     //     playerMoves[playerName].Add((start, end));
//     // }

//     // public void DisplayPlayerMoves()
//     // {
//     //     foreach (var playerMove in playerMoves)
//     //     {
//     //         Console.WriteLine($"Moves by {playerMove.Key}:");
//     //         foreach (var move in playerMove.Value)
//     //         {
//     //             Console.WriteLine($"From: ({move.start[0].X}, {move.start[0].Y}) To: ({move.end[0].X}, {move.end[0].Y})");
//     //         }
//     //     }
//     // }
// }
