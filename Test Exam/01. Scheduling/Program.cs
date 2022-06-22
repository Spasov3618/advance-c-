using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<int> problem = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int number = int.Parse(Console.ReadLine());

            while (problem.Any() && queue.Any())
            {
                int currProblem =problem.Peek();
                int currQueue = queue.Peek();
                if (currProblem == number)
                {
                    Console.WriteLine($"Thread with value {currQueue} killed task {number}");
                    Console.Write($"{string.Join(" ",queue)}");
                    Console.WriteLine();
                    return;
                }
                else if (currQueue>=currProblem)
                {
                    problem.Pop();
                    queue.Dequeue();
                }
                else if (currProblem>currQueue)
                {
                    queue.Dequeue();
                }


            }
        }
    }
}
