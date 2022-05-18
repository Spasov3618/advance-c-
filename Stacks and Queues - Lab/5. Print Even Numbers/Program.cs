using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> vs = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> vs1 = new Queue<int>();
            while (vs.Count>0)
            {
                if (vs.Peek() % 2 == 0)
                {
                    vs1.Enqueue(vs.Peek());
                }
                vs.Dequeue();
            }
            Console.Write($"{string.Join(", ", vs1)}");
        }
    }
}
