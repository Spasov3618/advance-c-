using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = num =>num.Min();
            Console.WriteLine(func(Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToArray()));
        }
    }
}
