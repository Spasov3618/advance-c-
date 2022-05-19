using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                if (row >= 0 && col >= 0 && jaggedArray.Length > row && jaggedArray[row].Length > col)
                {
                    if (command[0] == "Add")
                    {
                        jaggedArray[row][col] += int.Parse(command[3]);
                    }
                    else
                    {
                        jaggedArray[row][col] -= int.Parse(command[3]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine().Split();
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }
    }
}
