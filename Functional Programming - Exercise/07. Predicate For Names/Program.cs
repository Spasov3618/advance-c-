using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(Environment.NewLine,Console.ReadLine().Split().Where(x => x.Length<= num)));
        }
    }
}
