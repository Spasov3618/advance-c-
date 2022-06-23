using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
          Queue<int> rozes = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int count = 0;
            int flowers = 0;

            while (lilies.Count > 0 && rozes.Count > 0)
            {
                int currLilies = lilies.Peek();
                int currRozes = rozes.Peek();
                if (currLilies+currRozes == 15)
                {
                    count++;
                    lilies.Pop();
                    rozes.Dequeue();

                }
                else if (currLilies+currRozes>15)
                {
                    lilies.Push(lilies.Pop() - 2);
                }
                else if (currLilies+currRozes<15)
                {
                    flowers += currRozes + currLilies;
                    lilies.Pop();
                    rozes.Dequeue();
                }
            }

            if (flowers>15)
            {
                               
                    count += flowers / 15;
                
            }
            if (count>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {count} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-count} wreaths more!");
            }
        }
    }
}
