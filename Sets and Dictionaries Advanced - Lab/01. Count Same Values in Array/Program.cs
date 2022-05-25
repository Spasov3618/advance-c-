using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!result.ContainsKey(numbers[i]) )
                {
                    result.Add(numbers[i],1);
                }
                else
                {
                    result[numbers[i]]++;
                }
            }   
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
