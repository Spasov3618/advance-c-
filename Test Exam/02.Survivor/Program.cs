using System;

namespace _02.Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowNum = int.Parse(Console.ReadLine());
            string[][] matrix = new string[rowNum][];
            int moneyMi = 0;
            int MoneyAnadar = 0;
            for (int i = 0; i < rowNum; i++)
            {
                string[] input = Console.ReadLine().Split();
                matrix[i] = input;
            }
            string command;
            while ((command = Console.ReadLine()) != "Gong")
            {
                string[] arg = command.Split();
                int row = int.Parse(arg[1]);
                int col = int.Parse(arg[2]);
                if (arg[0] == "Find")
                {
                    if (isIndex(matrix, row, col) && matrix[row][col] == "T")
                    {
                        moneyMi++;
                        matrix[row][col] = "-";
                    }
                }
                else if (arg[0] == "Opponent")
                {
                    string direction = arg[3];
                    if (isIndex(matrix, row, col))
                    {
                        if (matrix[row][col] == "T")
                        {
                            MoneyAnadar++;
                            matrix[row][col] = "-";
                        }
                        if (direction == "up")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                row--;
                                if (isIndex(matrix,row,col))
                                {
                                    if (matrix[row][col] == "T")
                                    {
                                        MoneyAnadar++;
                                        matrix[row][col] = "-";
                                    }
                                }

                            }

                        }
                        else if (direction == "down")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                row++;
                                if (isIndex(matrix, row, col))
                                {
                                    if (matrix[row][col] == "T")
                                    {
                                        MoneyAnadar++;
                                        matrix[row][col] = "-";
                                    }
                                }

                            }
                        }
                        else if (direction == "left")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                col--;
                                if (isIndex(matrix, row, col))
                                {
                                    if (matrix[row][col] == "T")
                                    {
                                        MoneyAnadar++;
                                        matrix[row][col] = "-";
                                    }
                                }

                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                col++;
                                if (isIndex(matrix, row, col))
                                {
                                    if (matrix[row][col] == "T")
                                    {
                                        MoneyAnadar++;
                                        matrix[row][col] = "-";
                                    }
                                }

                            }
                        }
                    }
                }

            }
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
            Console.WriteLine($"Collected tokens: {moneyMi}");
            Console.WriteLine($"Opponent's tokens: {MoneyAnadar}");
        }

        private static bool isIndex(string[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
    }
}
