using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            List<int> list = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Enqueue(list[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
