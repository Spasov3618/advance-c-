using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int rowHero = 0;
            int colHero = 0;
            int counter = 1;
            int counterRods = 0;

            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'V')
                    {
                        rowHero = row;
                        colHero = col;
                    }
                }
            }
            string direction;
            while ((direction = Console.ReadLine()) != "End")
            {


                

                if (direction == "up" && rowHero-1>=0 )
                {
                matrix[rowHero, colHero] = '*';
                    rowHero--;

                    if (isIndex(n, rowHero, colHero) && matrix[rowHero, colHero] == 'R')
                    {
                        rowHero++;
                        matrix[rowHero, colHero] = 'V';
                        counterRods++;
                        Console.WriteLine("Vanko hit a rod!");

                    }
                }
                else if (direction == "down" && rowHero+1<n)
                {
                    matrix[rowHero, colHero] = '*';
                    rowHero++;
                    if (isIndex(n, rowHero, colHero) && matrix[rowHero, colHero] == 'R')
                    {
                        rowHero--;
                        matrix[rowHero, colHero] = 'V';
                        counterRods++;
                        Console.WriteLine("Vanko hit a rod!");

                    }
                }
                else if (direction == "left" && colHero-1 >=0)
                {
                    matrix[rowHero, colHero] = '*';
                    colHero--;
                    if (isIndex(n, rowHero, colHero) && matrix[rowHero, colHero] == 'R')
                    {
                        colHero++;
                        matrix[rowHero, colHero] = 'V';
                        counterRods++;
                        Console.WriteLine("Vanko hit a rod!");

                    }
                }
                else if (direction == "right" && colHero+1 <n)
                {
                    matrix[rowHero, colHero] = '*';
                    colHero++;
                    if (isIndex(n, rowHero, colHero) && matrix[rowHero, colHero] == 'R')
                    {
                        colHero--;
                        matrix[rowHero, colHero] = 'V';
                        counterRods++;
                        Console.WriteLine("Vanko hit a rod!");

                    }
                }
                else
                {
                    
                    continue;
                }
                if (isIndex(n, rowHero, colHero) && matrix[rowHero, colHero] == '*')
                {
                    matrix[rowHero, colHero] = 'V';
                    Console.WriteLine($"The wall is already destroyed at position [{rowHero}, {colHero}]!");
                }
                else if (isIndex(n, rowHero, colHero) && matrix[rowHero, colHero] == '-')
                {
                    matrix[rowHero, colHero] = 'V';
                    counter++;
                    
                }

                else if (isIndex(n, rowHero, colHero) && matrix[rowHero, colHero] == 'C')
                {
                    counter++;
                    matrix[rowHero, colHero] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {counter} hole(s).");
                    break;
                }
                
            }

                if (direction == "End")
                {
                    Console.WriteLine($"Vanko managed to make {counter} hole(s) and he hit only {counterRods} rod(s).");
                }
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
      

            public static bool isIndex(int n, int rowHero, int colHero)
            {
                return rowHero >= 0 && rowHero < n && colHero >= 0 && colHero < n;
            }
        }
    
}
