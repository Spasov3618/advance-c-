using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrix = int.Parse(Console.ReadLine());
            int rol = matrix;
            int col = matrix;
            char[,] matrix2 = new char[rol, col];
            for (int i = 0; i < rol; i++)
            {
                char[] element = Console.ReadLine().ToCharArray();
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = element[j];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < rol; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (symbol == matrix2[i,j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
