using System;
using System.Linq;

namespace _02._Warships
{
    internal class Program
    {
        static void Main()
        {
           int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n,n];
            string[] cordinates = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries);
            int playerOne = 0;
            int playerTwo = 0;

            for (int row = 0; row < n; row++)
            {
                string[] line =Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = line[col];
                    if (matrix[row,col] == "<")
                    {
                        playerOne++;
                    }
                    else if (matrix[row,col] == ">")
                    {
                        playerTwo++;
                    }
                }
            }
            int total = playerOne + playerTwo;
            for (int i = 0; i < cordinates.Length; i++)
            {
                int[] index = cordinates[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int rowIndex = index[0];
                int colIndex = index[1];

                if (isIndex(n, rowIndex, colIndex)&&matrix[rowIndex,colIndex] == "<")
                {
                    matrix[rowIndex, colIndex] = "X";
                    playerOne--;
                }
                else if (isIndex(n, rowIndex, colIndex)&&matrix[rowIndex,colIndex] == ">" )
                {
                    matrix[rowIndex, colIndex] = "X";
                    playerTwo--;
                }
                else if ( isIndex(n, rowIndex, colIndex)&&matrix[rowIndex,colIndex] == "#" )
                {
                     matrix[rowIndex, colIndex] = "X";
                    if (isIndex(n, rowIndex-1, colIndex-1) && matrix[rowIndex - 1, colIndex - 1] == "<")
                    {
                        matrix[rowIndex - 1, colIndex - 1] = "X";
                        playerOne--;
                    }
                    else if (isIndex(n, rowIndex - 1, colIndex - 1) && matrix[rowIndex - 1, colIndex - 1] == ">")
                    {
                        matrix[rowIndex - 1, colIndex - 1] = "X";
                        playerTwo--;
                    }
                    
                    if (isIndex(n, rowIndex - 1, colIndex) && matrix[rowIndex - 1, colIndex] == "<")
                    {
                        matrix[rowIndex - 1, colIndex ] = "X";
                        playerOne--;
                    }
                    else if (isIndex(n, rowIndex - 1, colIndex) && matrix[rowIndex - 1, colIndex ] == ">" )
                    {
                        matrix[rowIndex - 1, colIndex ] = "X";
                        playerTwo--;
                    }
                   
                    if ( isIndex(n, rowIndex - 1, colIndex + 1)&&matrix[rowIndex - 1, colIndex + 1] == "<" )
                    {
                        matrix[rowIndex - 1, colIndex + 1] = "X";
                        playerOne--;
                    }
                    else if (  isIndex(n, rowIndex - 1, colIndex + 1)&&matrix[rowIndex - 1, colIndex + 1] == ">")
                    {
                        matrix[rowIndex - 1, colIndex + 1] = "X";
                        playerTwo--;
                    }
                  
                    if (  isIndex(n, rowIndex, colIndex - 1)&&matrix[rowIndex , colIndex - 1] == "<")
                    {
                        matrix[rowIndex , colIndex - 1] = "X";
                        playerOne--;
                    }
                    else if (  isIndex(n, rowIndex, colIndex - 1)&&matrix[rowIndex , colIndex - 1] == ">")
                    {
                        matrix[rowIndex , colIndex - 1] = "X";
                        playerTwo--;
                    }
                   
                    if ( isIndex(n, rowIndex, colIndex + 1)&&matrix[rowIndex , colIndex + 1] == "<")
                    {
                        matrix[rowIndex , colIndex + 1] = "X";
                        playerOne--;
                    }
                    else if (  isIndex(n, rowIndex, colIndex + 1)&&matrix[rowIndex , colIndex + 1] == ">")
                    {
                        matrix[rowIndex , colIndex + 1] = "X";
                        playerTwo--;
                    }
                    
                    if ( isIndex(n, rowIndex + 1, colIndex - 1)&&matrix[rowIndex + 1, colIndex - 1] == "<" )
                    {
                        matrix[rowIndex +1, colIndex - 1] = "X";
                        playerOne--;
                    }
                    else if ( isIndex(n, rowIndex + 1, colIndex - 1)&&matrix[rowIndex + 1, colIndex - 1] == ">" )
                    {
                        matrix[rowIndex + 1, colIndex - 1] = "X";
                        playerTwo--;
                    }
                  
                    if ( isIndex(n, rowIndex + 1, colIndex)&&matrix[rowIndex +1, colIndex ] == "<" )
                    {
                        matrix[rowIndex +1, colIndex ] = "X";
                        playerOne--;
                    }
                    else if ( isIndex(n, rowIndex + 1, colIndex)&&matrix[rowIndex + 1, colIndex ] == ">" )
                    {
                        matrix[rowIndex + 1, colIndex ] = "X";
                        playerTwo--;
                    }
                   
                    if ( isIndex(n, rowIndex + 1, colIndex + 1)&&matrix[rowIndex + 1, colIndex + 1] == "<" )
                    {
                        matrix[rowIndex + 1, colIndex + 1] = "X";
                        playerOne--;
                    }
                    else if ( isIndex(n, rowIndex + 1, colIndex + 1)&&matrix[rowIndex + 1, colIndex + 1] == ">" )
                    {
                        matrix[rowIndex + 1, colIndex + 1] = "X";
                        playerTwo--;
                    }
                
                }
                if (playerOne == 0 && playerTwo == 0)
                {
                    break;
                }
            }
            if (playerTwo == 0)
            {
                Console.WriteLine($"Player One has won the game! {total-playerOne} ships have been sunk in the battle.");
            }
            else if (playerOne == 0)
            {
                Console.WriteLine($"Player Two has won the game! {total - playerTwo} ships have been sunk in the battle.");
            }
            if (playerOne>0 && playerTwo>0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOne} ships left. Player Two has {playerTwo} ships left.");
            }
        }

        private static bool isIndex(int n,int rowIndex, int colIndex)
        {
            return rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < n;
        }
    }
}
