using System;

namespace _02._Bee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];
            int rowBee = 0;
            int colBee = 0;
            int count = 0;

            for (int row = 0; row < n; row++)
            {
                char[] lines = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = lines[col];
                    if (matrix[row,col]== 'B')
                    {
                        rowBee = row;
                        colBee = col;
                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                matrix[rowBee, colBee] = '.';
                if (command == "up")
                {
                    rowBee--;
                    if (isIndex(matrix, rowBee, colBee) && matrix[rowBee,colBee]=='O')
                    {
                        matrix[rowBee, colBee] = '.';
                        rowBee --;
                    }
                }
                else if (command == "down")
                {
                    rowBee++;
                    if (isIndex(matrix, rowBee, colBee)&&matrix[rowBee, colBee] == 'O')
                    {
                        matrix[rowBee, colBee] = '.';
                        rowBee++;
                    }
                }
                else if (command == "left")
                {
                    colBee--;
                    if (isIndex(matrix, rowBee, colBee)&&matrix[rowBee, colBee] == 'O')
                    {
                        matrix[rowBee, colBee] = '.';
                        colBee--;
                    }
                }
                else if (command == "right")
                {
                    colBee++;
                    if (isIndex(matrix, rowBee, colBee)&&matrix[rowBee, colBee] == 'O')
                    {
                        matrix[rowBee, colBee] = '.';
                        colBee++;
                    }
                }
                if (isIndex(matrix,rowBee,colBee))
                {
                    if (matrix[rowBee,colBee] == 'f')
                    {
                        matrix[rowBee, colBee] = 'B';
                        count++;
                    }
                    else
                    {
                        matrix[rowBee, colBee] = 'B';
                    }
                   

                }
                else
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
            }

            if (count>= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {count} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5- count} flowers more");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();

            }
        }

        private static bool isIndex(char[,] matrix, int rowBee, int colBee)
        {
            return rowBee>=0 && rowBee<matrix.GetLength(0) && colBee>=0 && colBee<matrix.GetLength(1) ;
        }
    }
}
