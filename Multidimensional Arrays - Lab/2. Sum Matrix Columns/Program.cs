using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rol = matrix[0];
            int col = matrix[1];
            int[,] matrix2 = new int[rol, col];
            for (int i = 0; i < rol; i++)
            {
                int[] element = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = element[j];
                }
            }
            for (int m = 0; m < col; m++)
            {
            int sum = 0;
                for (int l = 0; l < rol; l++)
                {
                    sum += matrix2[l, m];
                }
                Console.WriteLine(sum);
            }
          
        }
    }
}
