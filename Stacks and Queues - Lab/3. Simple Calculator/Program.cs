using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> someStack = new Stack<string>(input.Split(" ").Reverse());

            int result = int.Parse(someStack.Pop());

            while (someStack.Any())
            {
                var nextSymbol = someStack.Pop();

                if (nextSymbol == "+" || nextSymbol == "-")
                {
                    if (nextSymbol == "+")
                    {
                        result += int.Parse(someStack.Pop());
                    }
                    else if (nextSymbol == "-")
                    {
                        result -= int.Parse(someStack.Pop());
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
