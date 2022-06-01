using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                        .Split()
                        .Select(int.Parse);

            int removeDivisible = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % removeDivisible != 0;

            Func<IEnumerable<int>, IEnumerable<int>> reverseFunc = x => x = x.Reverse();

            Console.WriteLine(string.Join(" ", reverseFunc(nums).Where(x => filter(x))));
        
    }
    }
}
