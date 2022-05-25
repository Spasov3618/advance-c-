using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int raws = int.Parse(input.Split()[0]);
            int col = int.Parse(input.Split()[1]);


            int[,] numbers = new int[raws, col];
            FillMatrix(numbers);
            int sum = int.MinValue;
                        int[,] matrix = new int[3,3];
            for (int i = 0; i < raws-2; i++)
            {
                for (int j = 0; j < col-2; j++)
                {
                    int curentSum = numbers[i, j] + numbers[i, j + 1] + numbers[i, j + 2] + numbers[i + 1, j] + numbers[i + 1, j + 1] + numbers[i + 1, j + 2] + numbers[i + 2, j] + numbers[i + 2, j + 1] + numbers[i + 2, j + 2];
                    if (curentSum>sum)
                    {
                        sum = curentSum;
                        matrix[0,0] = numbers[i, j];
                        matrix[0,1] = numbers[i, j + 1];
                        matrix[0,2] = numbers[i, j + 2];
                        matrix[1,0] = numbers[i+1, j];
                        matrix[1,1] = numbers[i+1, j+1];
                        matrix[1,2] = numbers[i+1, j+2];
                        matrix[2,0] = numbers[i+2, j];
                        matrix[2,1] = numbers[i+2, j+1];
                        matrix[2,2] = numbers[i+2, j+2];
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static void FillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
