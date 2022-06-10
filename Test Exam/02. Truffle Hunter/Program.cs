using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            fillMatrix(matrix);
           
            Dictionary<string, int> truffle = new Dictionary<string, int>
                { 
                { "B",0},
                { "S",0},
            { "W",0},
                };
            int counter = 0;
            
            string command;
            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                if (command.StartsWith("Collect"))
                {
                    int indexRow = int.Parse(command.Split(" ")[1]);
                    int indexCol = int.Parse(command.Split(" ")[2]);
                   
                    string a = matrix[indexRow, indexCol];
                    if (a == "B")
                    {
                        truffle["B"]++;
                        matrix[indexRow, indexCol] = "-";
                    }
                    else if (a == "S")
                    {
                        truffle["S"]++;
                        matrix[indexRow, indexCol] = "-";
                    }
                    else if (a == "W")
                    {
                        truffle["W"]++;
                        matrix[indexRow, indexCol] = "-";
                    }

                }
                else if (command.StartsWith("Wild_Boar"))
                {
                    int indexRow = int.Parse(command.Split(" ")[1]);
                    int indexCol = int.Parse(command.Split(" ")[2]);
                    string direction = command.Split()[3];
                  
                    switch (direction)
                    {
                        case "up":
                            for (int i = indexRow; i >= 0; i -= 2)
                            {

                                if (matrix[i,indexCol] != "-")
                                {
                                    counter++;
                                    matrix[i,indexCol] = "-";
                                }
                            }
                            break;
                        case "down":
                            for (int i = indexRow; i <= n-1; i+=2)
                            {

                                if (matrix[i,indexCol] != "-")
                                {
                                 counter++;
                                    matrix[i,indexCol] = "-";
                                }
                            }

                            break;
                        case "left":
                            for (int i = indexCol; i >= 0; i-=2)
                            {


                                if (matrix[indexRow,i] != "-")
                                {
                                    counter++;
                                    matrix[indexRow,i] = "-";
                                }
                            }
                            break;
                        case "right":
                            for (int i = indexCol; i <= n-1; i += 2)
                            {

                                if (matrix[indexRow,i] != "-")
                                {
                                    counter++;
                                    matrix[indexRow,i] = "-";
                                }
                            }
                            break;

                    }
                }         
            }
            Console.WriteLine($"Peter manages to harvest {truffle["B"]} black, {truffle["S"]} summer, and {truffle["W"]} white truffles.");
            Console.WriteLine($"The wild boar has eaten {counter} truffles.");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
            
        }

        private static void fillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            
        }
    }
}
