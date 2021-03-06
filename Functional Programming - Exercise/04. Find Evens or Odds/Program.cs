using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            string evenOrOdd = Console.ReadLine();

            Predicate<int> predicate = x => evenOrOdd == "even" ? x % 2 == 0 : x % 2 != 0;

            Console.WriteLine(string.Join(" ", Enumerable.Range(bounds[0], (bounds[1] - bounds[0]) + 1)
                                               .Where(x => predicate(x))));
        }
    }
}
