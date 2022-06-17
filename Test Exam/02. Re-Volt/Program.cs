using System;

namespace _02._Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCommand = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];
            int rowIndex = 0;
            int colIndex = 0;
            bool won = false;
            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();    
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = input[col];
                    if (matrix[row,col] == 'f')
                    {
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
            for (int i = 0; i < numCommand; i++)
            {
                string direction = Console.ReadLine();
                matrix[rowIndex, colIndex] = '-';
                if (direction== "up")
                {
                    if (rowIndex == 0)
                    {
                        rowIndex = n-1;
                        matrix[rowIndex, colIndex] = 'f';
                    }
                   else if (matrix[rowIndex - 1, colIndex] == 'F')
                    {
                        matrix[rowIndex - 1, colIndex] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }

                    else if (matrix[rowIndex-1,colIndex] == 'B')
                    {
                        
                        rowIndex-=2;
                        if (rowIndex>=0)
                        {
                        matrix[rowIndex, colIndex] = 'f';

                        }
                        else
                        {
                            rowIndex = n - 1;
                            matrix[rowIndex, colIndex] = 'f';
                        }
                        
                    }
                    else if (matrix[rowIndex-1,colIndex] == 'T')
                    {
                        matrix[rowIndex, colIndex] = 'f';

                    }

                    else
                    {
                        rowIndex--;
                        matrix[rowIndex, colIndex] = 'f';

                    }
                     if (matrix[rowIndex , colIndex] == 'F')
                    {
                        matrix[rowIndex , colIndex] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }


                }
                else if (direction== "down")
                {
                    if (rowIndex == n-1)
                    {
                        rowIndex = 0;
                        matrix[rowIndex, colIndex] = 'f';
                    }
                  else  if (matrix[rowIndex + 1, colIndex] == 'F')
                    {
                        matrix[rowIndex + 1, colIndex] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }
                    else if (matrix[rowIndex + 1, colIndex] == 'B')
                    {
                        
                        rowIndex += 2;
                        if (rowIndex<= n-1)
                        {
                        matrix[rowIndex, colIndex] = 'f';

                        }
                        else
                        {
                            rowIndex = 0;
                            matrix[rowIndex, colIndex] = 'f';
                        }

                    }
                    else if (matrix[rowIndex + 1, colIndex] == 'T')
                    {
                         matrix[rowIndex, colIndex] = 'f';

                    }
                   

                    else
                    {
                        rowIndex++;
                        matrix[rowIndex, colIndex] = 'f';
                    }
                     if (matrix[rowIndex , colIndex] == 'F')
                    {
                        matrix[rowIndex , colIndex] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }
                }
                else if (direction == "left")
                {
                    if (colIndex == 0)
                    {
                        colIndex = n-1;
                        matrix[rowIndex, colIndex] = 'f';
                    }
                  else  if (matrix[rowIndex, colIndex - 1] == 'F')
                    {
                        matrix[rowIndex, colIndex - 1] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }
                    else if (matrix[rowIndex , colIndex-1] == 'B')
                    {
                       
                        colIndex -= 2;
                        if (colIndex>=0)
                        {
                        matrix[rowIndex, colIndex] = 'f';

                        }
                        else
                        {
                            colIndex = n - 1;
                            matrix[rowIndex, colIndex] = 'f';
                        }

                    }
                    else if (matrix[rowIndex , colIndex-1] == 'T')
                    {
                        matrix[rowIndex, colIndex] = 'f';
                    }

                    else
                    {
                        colIndex--;
                        matrix[rowIndex, colIndex] = 'f';
                    }
                     if (matrix[rowIndex , colIndex] == 'F')
                    {
                        matrix[rowIndex , colIndex] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }
                }
                else if (direction == "right")
                {
                    if (colIndex==n-1)
                    {
                        colIndex = 0;
                        matrix[rowIndex, colIndex] = 'f';
                    }
                  else  if (matrix[rowIndex, colIndex + 1] == 'F')
                    {
                        matrix[rowIndex, colIndex + 1] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }
                    else if (matrix[rowIndex, colIndex + 1] == 'B')
                    {
                        
                        colIndex += 2;
                        if (colIndex<= n-1)
                        {

                        matrix[rowIndex, colIndex] = 'f';
                        }
                        else
                        {
                            colIndex = 0;
                            matrix[rowIndex, colIndex] = 'f';
                        }

                    }
                    else if (matrix[rowIndex, colIndex + 1] == 'T')
                    {
                        matrix[rowIndex, colIndex] = 'f';

                    }

                    else
                    {
                        colIndex++;
                        matrix[rowIndex, colIndex] = 'f';
                    }
                     if (matrix[rowIndex , colIndex] == 'F')
                    {
                        matrix[rowIndex , colIndex] = 'f';
                        Console.WriteLine("Player won!");
                        won = true;
                        break;
                    }
                }
            }
            if (!won)
            {
                Console.WriteLine("Player lost!");
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();

            }
        }
    }
}
