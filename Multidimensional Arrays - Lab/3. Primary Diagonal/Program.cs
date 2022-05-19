using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrix = int.Parse(Console.ReadLine());
            int rol = matrix;
            int col = matrix;
            int[,] matrix2 = new int[rol, col];
            for (int i = 0; i < rol; i++)
            {
                int[] element = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = element[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < rol; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    sum += matrix2[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
