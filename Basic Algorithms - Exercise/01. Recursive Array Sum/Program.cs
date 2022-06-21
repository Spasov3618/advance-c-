using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = RecursionSum(arr, 0);
            Console.WriteLine(sum);
        }

        private static int RecursionSum(int[] arr, int v)
        {
            if (v == arr.Length-1)
            {
                return arr[v];
            }
            int sum = arr[v] + RecursionSum(arr,v+1);
            return sum;
        }
    }
}
