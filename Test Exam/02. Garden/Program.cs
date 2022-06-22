using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizeMatrix[0], sizeMatrix[1]];
            string command;
            
            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] cordinates = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = cordinates[0];
                int col = cordinates[1];
                if (row >= 0 && row < sizeMatrix[0] && col >= 0 && col < sizeMatrix[1])
                {
                    matrix[row, col] = 1;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[row, i]++;
                        matrix[i, col]++;
                    }
                    matrix[row, col] -= 2;

                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
