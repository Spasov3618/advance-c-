using System;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Console.ReadLine().Split(). First(x => x.Select(number => (int) number).Sum() >= num )) ;
        }
    }
}
