using System;

namespace _02._Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int rowBee = 0;
            int colBee = 0;
            int count = 0;
            int rowBarr = 0;
            int colBarr = 0;
            int rowSecondBarr = 0;
            int colSecondBarr = 0;
            int food = 0;

            for (int row = 0; row < n; row++)
            {
                char[] lines = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = lines[col];
                    if (matrix[row, col] == 'S')
                    {
                        rowBee = row;
                        colBee = col;
                    }
                    else if (matrix[row, col] == 'B')
                    {
                        if (count == 0)
                        {
                            rowBarr = row;
                            colBarr = col;
                        }
                        else
                        {
                            rowSecondBarr = row;
                            colSecondBarr = col;
                        }
                    }
                }
            }

            while (true)
            {
                string direction = Console.ReadLine();
                matrix[rowBee, colBee] = '.';
                Position(ref rowBee, ref colBee, direction);
               
                if (isIndex(n, rowBee, colBee))
                {
                    Check(matrix, ref rowBee, ref colBee, rowBarr, colBarr, rowSecondBarr, colSecondBarr, ref food);
                    if (food == 10)
                    {
                        Console.WriteLine("You won! You fed the snake.");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Food eaten: {food}");
                    break;
                }
            }

            PrintMatrix(n, matrix);
        }

        private static void Position(ref int rowBee, ref int colBee, string direction)
        {
            if (direction == "up")
            {
                rowBee--;
            }
            else if (direction == "down")
            {
                rowBee++;
            }
            else if (direction == "left")
            {
                colBee--;

            }
            else if (direction == "right")
            {
                colBee++;
            }
        }

        private static void Check(char[,] matrix, ref int rowBee, ref int colBee, int rowBarr, int colBarr, int rowSecondBarr, int colSecondBarr, ref int food)
        {
            if (matrix[rowBee, colBee] == '*')
            {
                matrix[rowBee, colBee] = 'S';
                food++;
            }
            else if (matrix[rowBee, colBee] == 'B')
            {
                if (rowBee == rowBarr)
                {
                    matrix[rowBee, colBee] = '.';
                    rowBee = rowSecondBarr;
                    colBee = colSecondBarr;
                    matrix[rowBee, colBee] = 'S';
                }
                else
                {
                    matrix[rowBee, colBee] = '.';
                    rowBee = rowBarr;
                    colBee = colBarr;
                    matrix[rowBee, colBee] = 'S';
                }
            }
            else
            {
                matrix[rowBee, colBee] = 'S';
            }
        }

        private static void PrintMatrix(int n, char[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write(matrix[i, h]);
                }
                Console.WriteLine();
            }
        }

        private static bool isIndex(int n, int rowBee, int colBee)
        {
            return rowBee >= 0 && rowBee < n && colBee >= 0 && colBee < n;
        }
    }
}
