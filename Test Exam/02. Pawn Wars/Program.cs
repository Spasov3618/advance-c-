using System;
using System.Text;

namespace _02._Pawn_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chess = new char[8, 8];
            int rowWhite = 0;
            int colWhite = 0;
            int rowBlack = 0;
            int colBlack = 0;
            for (int row = 0; row < 8; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < 8; col++)
                {
                    chess[row, col] = input[col];
                    if (chess[row,col] == 'w')
                    {
                        rowWhite=row;
                        colWhite=col;
                    }
                    else if (chess[row,col] == 'b')
                    {
                        rowBlack = row;
                        colBlack=col;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                chess[rowWhite, colWhite] = '-';
                if (chess[rowWhite-1,colWhite-1] == 'b')
                {
                    string position = SetPosition(rowWhite-1, colWhite-1);
                    Console.WriteLine($"Game over! White capture on {position}.");
                    return;
                }
                else if (chess[rowWhite - 1, colWhite + 1] == 'b')
                {
                    string position = SetPosition(rowWhite-1, colWhite+1);
                    Console.WriteLine($"Game over! White capture on {position}.");
                    return;
                }

                else
                {
                    rowWhite = rowWhite - 1;

                    if (rowWhite == 0)
                    {
                        string position = SetPosition(rowWhite, colWhite);
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {position}.");
                        return;
                    }
                   chess[rowWhite,colWhite] = 'w';
                }
                chess[rowBlack, colBlack] = '-';
                if (chess[rowBlack + 1, colBlack - 1] == 'w')
                {
                    string position = SetPosition(rowBlack+1, colBlack-1);
                    Console.WriteLine($"Game over! Black capture on {position}.");
                    return;
                }
                else if (chess[rowBlack + 1, colBlack + 1] == 'b')
                {
                    string position = SetPosition(rowBlack+1, colBlack+1);
                    Console.WriteLine($"Game over! Black capture on {position}.");
                    return;
                }
                else
                {
                    rowBlack = rowBlack + 1;
                    if (rowBlack == 7)
                    { 
                     string position = SetPosition(rowBlack,colBlack);
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {position}.");
                        return;
                    }
                 chess[ rowBlack,colBlack] = 'b';
                }
            }
          
        }
        private static string SetPosition(int row, int col)
        {

            var sb = new StringBuilder();

            for (int i = 8; i >= 0; i--)
            {
                if (col == i)
                {
                    sb.Append((char)(i + 97));
                }
            }

            int counter = 8;
            for (int i = 0; i < 8; i++)
            {
                if (row == i)
                {
                    sb.Append(counter);
                }
                counter--;
            }
            return $"{sb}";
        }
    }
}
