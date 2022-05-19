using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
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
            int[,] maxSumMatrix = new int[2, 2];
            int maxSum = int.MinValue;

            for (int i = 0; i < rol - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (matrix2[i, j] + matrix2[i, j + 1] + matrix2[i + 1, j] + matrix2[i + 1, j + 1] > maxSum)
                    {
                        maxSum = matrix2[i, j] + matrix2[i, j + 1] + matrix2[i + 1, j] + matrix2[i + 1, j + 1];
                        maxSumMatrix[0, 0] = matrix2[i, j];
                        maxSumMatrix[0, 1] = matrix2[i, j + 1];
                        maxSumMatrix[1, 0] = matrix2[i + 1, j];
                        maxSumMatrix[1, 1] = matrix2[i + 1, j + 1];
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(maxSumMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
    }
