using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> complect = new Queue<int>();
            while (hats.Any() && scarfs.Any())
            {
                int currHat = hats.Peek();
                int currScarf = scarfs.Peek();
                if (currHat<currScarf)
                {
                    hats.Pop();

                }
               else if (currHat>currScarf)
                {
                    complect.Enqueue(currHat + currScarf);
                    hats.Pop();
                    scarfs.Dequeue();
                }
               else if (currHat == currScarf)
                {
                    currHat++;
                    hats.Pop();
                    hats.Push(currHat);
                    scarfs.Dequeue();
                }
            }
            Console.WriteLine($"The most expensive set is: {complect.Max()}");
            Console.Write(string.Join(" ",complect));
            Console.WriteLine();
        }
    }
}
