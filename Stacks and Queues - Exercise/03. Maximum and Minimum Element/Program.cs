using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] cmn = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int command = cmn[0];
                if (command == 1)
                {
                    stack.Push(cmn[1]);
                }
                else if (command == 2)
                {
                    if (stack.Count > 0)
                    {

                    stack.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (stack.Count==0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command == 4)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine($"{string.Join(", ", stack)}");
        }
    }
}
