using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
           SortedDictionary<string, int> food = new SortedDictionary<string, int>
            {
                {"Bread",0 },
                {"Cake",0 },
                {"Pastry",0 },
                {"Fruit Pie",0}
            };
            while (liquids.Any() && ingredients.Any())
            {
                if (liquids.Peek()+ingredients.Peek() == 25)
                {
                    food["Bread"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquids.Peek()+ingredients.Peek() == 50)
                {
                    food["Cake"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquids.Peek()+ingredients.Peek()== 75)
                {
                    food["Pastry"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquids.Peek() + ingredients.Peek() == 100)
                {
                    food["Fruit Pie"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Push(ingredients.Pop() + 3);
                }
            }
            if (food.Values.All(n=> n>0))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count==0)
            {
                Console.WriteLine($"Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquids)}");
            }
            if (ingredients.Count == 0)
            {
                Console.WriteLine($"Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            foreach (var item in food)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
