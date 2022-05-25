using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> set = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < input.Length; j++)
                {
                    set.Add(input[j]);
                }
            }
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
        }
    }
}
