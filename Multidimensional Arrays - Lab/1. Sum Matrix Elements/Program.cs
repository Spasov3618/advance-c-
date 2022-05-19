using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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
                int[] element = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = element[j];
                }
            }
            int sum = 0;
            for (int m = 0; m < rol; m++)
            {
                for (int l = 0; l < col; l++)
                {
                    sum += matrix2[m, l];
                }
            }
            Console.WriteLine(rol);
            Console.WriteLine(col);
            Console.WriteLine(sum);
        }
    }
}
