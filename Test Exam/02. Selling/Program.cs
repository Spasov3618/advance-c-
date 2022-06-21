using System;

namespace _02._Selling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int .Parse(Console.ReadLine());
            char[,] bakery = new char[n, n];
            int rowIndex = 0;
            int colIndex = 0;
            int rowFirstPillars = 0;
            int colFirstPillars = 0;
            int rowSecondPillars = 0;
            int colSecondPillars = 0;
            int countPillars = 0;
            int money = 0;

            for (int row = 0; row < n; row++)
            {
                char[] inputLine = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    bakery[row, col] = inputLine[col];
                    if (bakery[row,col] == 'S')
                    {
                        rowIndex = row;
                        colIndex = col;
                    }
                    if (bakery[row,col] == 'O')
                    {
                        if (countPillars ==0)
                        {
                            rowFirstPillars = row;
                            colFirstPillars = col;
                            countPillars++;
                        }
                        else
                        {
                        rowSecondPillars = row;
                            colSecondPillars = col;

                        }
                    }
                }

            }

            while (true)
            {
                string direction = Console.ReadLine();
                bakery[rowIndex, colIndex] = '-';
                if (direction == "up")
                {
                    rowIndex--;

                    
                }
                else if (direction == "down")
                {
                    rowIndex++;
                }
                else if (direction == "left")
                {
                    colIndex--;
                }
                else if (direction == "right")
                {
                    colIndex++;
                }
                if (isIndex(n,rowIndex,colIndex))
                {
                   
                    if (bakery[rowIndex,colIndex] == 'O')
                    {
                        if (rowIndex==rowFirstPillars)
                        {
                            rowIndex = rowSecondPillars;
                            colIndex = colSecondPillars;
                            bakery[rowFirstPillars, colFirstPillars] = '-';
                            bakery[rowIndex, colIndex] = 'S';
                        }
                        else if (rowIndex == rowSecondPillars)
                        {
                            rowIndex = rowFirstPillars;
                            colIndex = colFirstPillars;
                            bakery[rowSecondPillars, colSecondPillars] = '-';
                            bakery[rowIndex, colIndex] = 'S';
                        }

                    }
                    if (char.IsDigit(bakery[rowIndex,colIndex]))
                    {
                        money +=(int)char.GetNumericValue(bakery[rowIndex, colIndex]);
                        bakery[rowIndex,colIndex] = 'S';
                        if (money>= 50)
                        {
                            Console.WriteLine("Good news! You succeeded in collecting enough money!");
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
            }
            Console.WriteLine($"Money: { money}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(bakery[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static bool isIndex(int n, int rowIndex, int colIndex)
        {
            return rowIndex>=0 && rowIndex<n && colIndex>= 0 && colIndex<n;
        }
    }
}
