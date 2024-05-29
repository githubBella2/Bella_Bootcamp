using System.Drawing;
using GameCheckker.Interface;

namespace GameCheckker.Class;

public class Board : IBoard
{
    private const int _size = 8;
    private IPiece[,] grid;

    public Board()
    {
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
            Console.Write(" " + x);
        }
        Console.WriteLine();

        for (int y = 0; y < _size; y++)
        {
            Console.Write(y + " ");
            for (int x = 0; x < _size; x++)
            {
                IPiece piece = grid[x, y];
                char symbol = piece.Type switch
                {
                    PieceType.White => 'W',
                    PieceType.Black => 'B',
                    _ => '|'
                };
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }
    public bool MovePiece(int startX, int startY, int endX, int endY, PieceType playerType)
    {
        IPiece piece = grid[startX, startY];
        // if (piece == null || piece.Type == PieceType.Empty)
        if (piece == null || piece.Type != playerType)

        {
            return false;
        }

        int dx = endX - startX;
        int dy = endY - startY;
        // Validate move direction
        // if (playerType == PieceType.White && dy >= 0)
        // {
        //     return false; // Red pieces must move down
        // }

        // if (playerType == PieceType.Black && dy <= 0)
        // {
        //     return false; // Black pieces must move up
        // }

        //memeriksa apakah gerakan valid
        if (Math.Abs(dx) == 1 && Math.Abs(dy) == 1)
        {
            //Cek apakah ada bidak di posisi akhir
            IPiece endPiece = grid[endX, endY];
            if (endPiece != null && endPiece.Type != PieceType.Empty)
            {
                return false; // tidak bisa bergerak ke posisi yang sudah ditempati
            }

            // Memindahkan ke posisi akhir
            grid[endX, endY] = piece;
            grid[startX, startY] = new Piece(PieceType.Empty);
            return true;
        }

        // 2
        if (Math.Abs(dx) == 2 && Math.Abs(dy) == 2)
        {
            int captureX = startX + dx / 2;
            int captureY = startY + dy / 2;
            IPiece capturedPiece = grid[captureX, captureY];

            if (capturedPiece != null && capturedPiece.Type != PieceType.Empty && capturedPiece.Type != piece.Type)
            {
                // Menangkap bidak
                grid[captureX, captureY] = new Piece(PieceType.Empty);
                grid[endX, endY] = piece;
                grid[startX, startY] = new Piece(PieceType.Empty);
                return true;
            }
        }
        return false;
    }



}
