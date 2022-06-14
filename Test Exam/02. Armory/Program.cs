using System;
using System.Linq;

namespace _02._Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            char[,] armory = new char[n,n];
            int rowIndex = 0;
            int colIndex = 0;
            int goldCoins = 0;
            int rowMirror1 = 0;
            int colMirror1 = 0;
            int rowMirror2 = 0;
            int colMirror2 = 0;
            int mirrorCount = 0;

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    armory[row,col] = input[col];

                    if (armory[row,col] == 'A')
                    {
                        rowIndex = row;
                        colIndex = col;
                    }
                    if (armory[row,col] == 'M')
                    {
                        if (mirrorCount==0)
                        {
                            rowMirror1 = row;
                            colMirror1 = col;
                            mirrorCount++;  
                        }
                        rowMirror2 = row;
                        colMirror2 = col;
                    }
                   
                }
                                      
            }

            while (true)
            {
                string directions = Console.ReadLine();
                armory[rowIndex, colIndex] = '-';

                switch (directions)
                {
                    case "up":
                        rowIndex--;
                        if (isIndex(armory, rowIndex, colIndex))
                        {


                            if (armory[rowIndex, colIndex] == 'M')
                            {
                                if (rowIndex == rowMirror1 && colIndex == colMirror1)
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror2;
                                    colIndex = colMirror2;
                                    armory[rowIndex, colIndex] = 'A';

                                }
                                else
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror1;
                                    colIndex = colMirror1;
                                    armory[rowIndex, colIndex] = 'A';
                                }
                            }
                            else if (char.IsDigit(armory[rowIndex, colIndex]))
                            {
                                int gold = int.Parse(armory[rowIndex, colIndex].ToString());
                                goldCoins += gold;

                                armory[rowIndex, colIndex] = 'A';


                            }
                            else
                            {
                                armory[rowIndex, colIndex] = 'A';
                            }
                        }
                            break;
                    case "down":
                        rowIndex++;
                        if (isIndex(armory, rowIndex, colIndex))
                        {


                            if (armory[rowIndex, colIndex] == 'M')
                            {
                                if (rowIndex == rowMirror1 && colIndex == colMirror1)
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror2;
                                    colIndex = colMirror2;
                                    armory[rowIndex, colIndex] = 'A';

                                }
                                else
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror1;
                                    colIndex = colMirror1;
                                    armory[rowIndex, colIndex] = 'A';
                                }
                            }
                            else if (char.IsDigit(armory[rowIndex, colIndex]))
                            {
                                int gold = int.Parse(armory[rowIndex, colIndex].ToString());
                                goldCoins += gold;

                                armory[rowIndex, colIndex] = 'A';


                            }
                            else
                            {
                                armory[rowIndex, colIndex] = 'A';
                            }
                        }
                            break;
                    case "left":
                        colIndex--;
                        if (isIndex(armory, rowIndex, colIndex))
                        {


                            if (armory[rowIndex, colIndex] == 'M')
                            {
                                if (rowIndex == rowMirror1 && colIndex == colMirror1)
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror2;
                                    colIndex = colMirror2;
                                    armory[rowIndex, colIndex] = 'A';

                                }
                                else
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror1;
                                    colIndex = colMirror1;
                                    armory[rowIndex, colIndex] = 'A';
                                }
                            }
                            else if (char.IsDigit(armory[rowIndex, colIndex]))
                            {
                                int gold = int.Parse(armory[rowIndex, colIndex].ToString());
                                goldCoins += gold;

                                armory[rowIndex, colIndex] = 'A';


                            }
                            else
                            {
                                armory[rowIndex, colIndex] = 'A';
                            }
                        }
                            break;
                    case "right":
                        colIndex++;
                        if (isIndex(armory, rowIndex, colIndex))
                        {
                            if (armory[rowIndex, colIndex] == 'M')
                            {
                                if (rowIndex == rowMirror1 && colIndex == colMirror1)
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror2;
                                    colIndex = colMirror2;
                                    armory[rowIndex, colIndex] = 'A';

                                }
                                else
                                {
                                    armory[rowIndex, colIndex] = '-';
                                    rowIndex = rowMirror1;
                                    colIndex = colMirror1;
                                    armory[rowIndex, colIndex] = 'A';
                                }
                            }
                            else if (char.IsDigit(armory[rowIndex, colIndex]))
                            {
                                int gold = int.Parse(armory[rowIndex, colIndex].ToString());
                                goldCoins += gold;

                                armory[rowIndex, colIndex] = 'A';


                            }
                            else
                            {
                                armory[rowIndex, colIndex] = 'A';
                            }
                        }
                        break;
                }

                if (!isIndex(armory, rowIndex, colIndex))
                {
                    Console.WriteLine("I do not need more swords!");
                    Console.WriteLine($"The king paid {goldCoins} gold coins.");
                    pringingMatrix(armory);

                }


                if (goldCoins >= 65)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    Console.WriteLine($"The king paid {goldCoins} gold coins.");
                    pringingMatrix(armory);

                }
            }
                
            
        }

       

        public static bool isIndex(char[,] armory,int rowIndex, int colIndex)
        {
            return rowIndex >= 0 && rowIndex <= armory.GetLength(0) && colIndex >= 0 && colIndex <= armory.GetLength(1);
        }
        public static void pringingMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
