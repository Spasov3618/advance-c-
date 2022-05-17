using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openingBrackets = new Stack<int>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openingBrackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = openingBrackets.Pop();

                    sb.AppendLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }

            Console.Write(sb);
        }
    }
}
