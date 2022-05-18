using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Console.WriteLine(queue.Max());
            int counter = queue.Count();
            for (int i = 0; i < counter; i++)

            {

                if (queue.Peek() <= food)
                {
                    food -= queue.Peek();
                    queue.Dequeue();
                }
                else 
                {
                    break;  
                }
            }
            if (queue.Count == 0)
            {
            Console.WriteLine("Orders complete");

            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ", queue));
            }
            
        }
    }
}
