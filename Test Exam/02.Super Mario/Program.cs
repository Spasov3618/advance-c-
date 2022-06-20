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
            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().ToCharArray();

                batal[row] = input;
                if (input.Contains('M'))
                {
                    indexRow = row;
                    indexCol = input.ToList().IndexOf('M');
                }

            }
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string direct = command[0];
                int rowOrk = int.Parse(command[1]);
                int colOrk =int.Parse(command[2]);
                batal[rowOrk][colOrk] = 'B';
                armor--;
                batal[indexRow][indexCol] = '-';


                if (direct == "W" && indexRow - 1 >= 0)
                {
                    indexRow--;




                }
                else if (direct == "S" && indexRow + 1 < n)
                {

                    indexRow++;


                }
                else if (direct == "A" && indexCol - 1 >= 0)
                {

                    indexCol--;

                }
                else if (direct == "D" && indexCol + 1 <= batal[0].Length)
                {
                    indexCol++;

                }

                if (batal[indexRow][indexCol] == 'B')
                {
                    armor -= 2;

                }
                else if (batal[indexRow][indexCol] == 'P')
                {

                    batal[indexRow][indexCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: { armor}");
                    break;
                }

                if (armor <= 0)
                {
                    batal[indexRow][indexCol] = 'X';
                    Console.WriteLine($"Mario died at {indexRow};{indexCol}.");
                    break;
                }
                batal[indexRow][indexCol] = 'M';
            }
            for (int row = 0; row < batal.Length; row++)
            {
                Console.WriteLine(new string(batal[row]));
            }
        }


    }
}
