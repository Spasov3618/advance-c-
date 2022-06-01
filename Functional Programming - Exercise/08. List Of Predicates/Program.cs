using System;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNum = int.Parse(Console.ReadLine());

            var numbers = Enumerable.Range(1, lastNum > 0 ? lastNum : 0);

            var divisors = Console.ReadLine().Split().Select(int.Parse);

            Predicate<int> filter = x => divisors.All(d => x % d == 0);

            Console.WriteLine(string.Join(" ", numbers.Where(x => filter(x))));
        }
    }
}
