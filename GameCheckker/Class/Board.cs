using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using GameCheckker.Interface;

namespace GameCheckker.Class;

public class Board : IBoard
{
    private const int _size = 8;
    private IPiece[,] grid;
    // public List<Coordinate> listCoordinateMove;
    // public Dictionary<IPlayer, List<Coordinate>> movePlayer;
   
    public Board()
    {
        #region CATATAN
        // GameController gameController = new GameController();
        //field / method utk board saja. Jadi current player dll dipanggil di gc.
        // GC Tidak bisa dipanggil di kelas panggil. 
        // method savemove pindah ke GC
        #endregion
        grid = new IPiece[_size, _size];
        InitBoard();
    }
    private void InitBoard()
    {
        for (int y = 0; y < _size; y++)
        {
            for (int x = 0; x < _size; x++)
            {
                if ((x + y) % 2 == 1)
                {
                    if (y < 3)
                    {
                        grid[x, y] = new Piece(PieceType.White);
                    }
                    else if (y > 4)
                    {
                        grid[x, y] = new Piece(PieceType.Black);
                    }
                    else
                    {
                        grid[x, y] = new Piece(PieceType.Empty);
                    }
                }
                else
                {
                    grid[x, y] = new Piece(PieceType.Empty);
                }
            }
        }

    }

    public void DisplayBoard()
    {
        System.Console.WriteLine("          ");

        for (int x = 0; x < _size; x++)
        {
            Console.Write("  " + x);
        }
        Console.WriteLine();

        for (int y = 0; y < _size; y++)
        {
            Console.Write(y + " ");
            for (int x = 0; x < _size; x++)
            {
                IPiece piece = grid[x, y];
                char symbol;
                if (piece.Type == PieceType.White)
                {
                    symbol = 'W';
                }
                else if (piece.Type == PieceType.Black)
                {
                    symbol = 'B';
                }
                else
                {
                    symbol = '|';
                }
                Console.Write(symbol + "  ");
            }
            Console.WriteLine();
        }
    }
    public bool MovePiece(Coordinate start, Coordinate end, PieceType playerType, Player currentPlayer)
    {
        IPiece  piece = grid[start.X, start.Y];// get piece at the starting position

        int dx = end.X - start.X; 
        int dy = end.Y - start.Y;

        //memeriksa apakah gerakan valid
        if (Math.Abs(dx) == 1 && Math.Abs(dy) == 1)
        {
            //Cek apakah ada bidak di posisi akhir
            IPiece endPiece = grid[end.X, end.Y];
            if (endPiece != null && endPiece.Type != PieceType.Empty)
            {
                return false; // tidak bisa bergerak ke posisi yang sudah ditempati
            }

            // Memindahkan ke posisi akhir
            grid[end.X, end.Y] = piece;
            grid[start.X, start.Y] = new Piece(PieceType.Empty);
            return true;

        }

        // 2
        if (Math.Abs(dx) == 2 && Math.Abs(dy) == 2)
        {
            int captureX = start.X + dx / 2;
            int captureY = start.Y + dy / 2;
            IPiece capturedPiece = grid[captureX, captureY];

            if (capturedPiece != null && capturedPiece.Type != PieceType.Empty && capturedPiece.Type != piece.Type)
            {
                // Menangkap 
                grid[captureX, captureY] = new Piece(PieceType.Empty);
                grid[end.X, end.Y] = piece;
                grid[start.X, start.Y] = new Piece(PieceType.Empty);

                #region SAMPAH
                // --
                // UpdatePiecePosition(username, start[0], end[0], playerType);
                // RemovePiecePosition(username, new Coordinate(captureX, captureY));
                // if (playerType == PieceType.White && end[0].Y == 0)
                // {
                //     piece.State = PieceState.King;
                // }
                // else if (playerType == PieceType.Black && end[0].Y == _size - 1)
                // {
                //     piece.State = PieceState.King;
                // }
                #endregion
                currentPlayer.AddScore(1);
               
                return true;
            }
        }
        return false;
    }

}
