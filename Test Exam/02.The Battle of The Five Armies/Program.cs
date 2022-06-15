using System;
using System.Linq;

namespace _02.The_Battle_of_The_Five_Armies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[][] batal = new char[n][];
            int indexRow = 0;
            int indexCol = 0;
            for (int row = 0; row <n ; row++)
            {
               var input = Console.ReadLine().ToCharArray();
                
                batal[row] = input;
                    if (input.Contains('A'))
                    {
                        indexRow = row;
                    indexCol = input.ToList().IndexOf('A');
                    }
               
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string direct = command[0];
                int rowOrk = int.Parse(command[1]);
                int colOrk = int.Parse(command[2]);
                batal[rowOrk][ colOrk] = 'O';
                armor--;
                batal[indexRow][ indexCol] = '-';


                if (direct == "up" && indexRow - 1 >=0)
                {
                    indexRow--;




                }
                else if (direct == "down" &&  indexRow + 1 < n)
                {

                    indexRow++;


                }
                else if (direct == "left" &&  indexCol - 1 >= 0)
                {

                    indexCol--;

                }
                else if (direct == "right" &&  indexCol + 1 <= batal[0].Length)
                {
                    indexCol++;

                }

                if (batal[indexRow][ indexCol] == 'O')
                {
                    armor -= 2;

                }
                else if (batal[indexRow][ indexCol] == 'M')
                {

                    batal[indexRow][ indexCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }

                if (armor <= 0)
                {
                    batal[indexRow ][ indexCol] = 'X';
                    Console.WriteLine($"The army was defeated at {indexRow };{indexCol}.");
                    break;
                }
                batal[indexRow][indexCol] = 'A';
            }
            for (int row = 0; row < batal.Length; row++)
            {
                Console.WriteLine(new string(batal[row]));
            }
        }

       
    }
}
