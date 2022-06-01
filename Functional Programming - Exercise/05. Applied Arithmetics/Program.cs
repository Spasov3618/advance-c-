using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<int, int> func = null;
            Action<List<int>> print = x => Console.WriteLine(String.Join(" ", x));
            string command;
            while ((command=Console.ReadLine()) != "end")
            {
                if (command== "add")
                {
                    input = input.Select( func = x => x += 1).ToList();
                }
                else if (command== "multiply")
                {
                    input = input.Select(func = x => x *= 2).ToList();
                }
                else if (command == "subtract")
                {
                    input = input.Select(func = x => x -= 1).ToList();
                }
                else if (command == "print")
                {
                    print(input);

                }
            }

        }
    }
}
