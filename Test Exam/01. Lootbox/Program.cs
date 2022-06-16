
namespace _01._Lootbox
{
using System;
using System.Collections.Generic;
using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
           Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int total = 0;
            while (firstBox.Any() && secondBox.Any())
            {
                int sum = firstBox.Peek() + secondBox.Peek();
                if (sum %2 == 0)
                {
                    total += sum;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }
            if (firstBox.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count==0)    
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (total>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {total}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {total}");
            }
        }
    }
}
