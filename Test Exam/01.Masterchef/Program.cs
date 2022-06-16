using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>
            {
                {"Dipping sauce",  0 },
                {"Green salad",  0 },
                {"Chocolate cake",  0 },
                {"Lobster",  0 },
           

            };
            Queue<int> ingredient = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Where(n => n != 0 ));
            Stack <int> freshness = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));


            while (ingredient.Count>0 && freshness.Count>0)
            {

                int total = ingredient.Peek() * freshness.Peek();
               
                 if (total == 150)
                {
                    dictionary["Dipping sauce"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (total == 250)
                {
                    dictionary["Green salad"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (total == 300)
                {
                    dictionary["Chocolate cake"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (total == 400)
                {
                    dictionary["Lobster"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    int newInkr = ingredient.Dequeue()+5;
                    ingredient.Enqueue(newInkr);
                }

            }
            if (dictionary.Values.All(n => n>0))
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
              
            }
                if (ingredient.Count>0)
                {
                    Console.WriteLine($"Ingredients left: {ingredient.Sum()}");
                }

            foreach (var item in dictionary)
            {
                if (item.Value>0)
                {
                Console.WriteLine($" # {item.Key} --> {item.Value}");

                }
            }


        }
    }
}
