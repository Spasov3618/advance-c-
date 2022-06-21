using System;

namespace _02._Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           
            long sum = FactorielS(n);
           
            Console.WriteLine(sum);
        }

        public static long FactorielS(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            long sum = n * FactorielS(n - 1);
            return sum;
        }
    }
}
