using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<string> queue = new Queue<string>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                if (cmd != "Paid")
                {
                    queue.Enqueue(cmd);
                }
                else if (cmd == "Paid")
                {
                    while(queue.Count > 0)
                    {
                    Console.WriteLine(queue.Dequeue());

                    }
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
