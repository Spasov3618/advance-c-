using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
           Stack<int> whiteTile = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
           Queue<int> greyTile = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            SortedDictionary<string, int> map = new SortedDictionary<string, int>
        {
            {"Sink",0},
            {"Oven",0},
            {"Countertop",0},
            {"Wall",0},
                {"Floor",0 }
        };
           

            while (whiteTile.Any() && greyTile.Any())
            {
                int currWhite = whiteTile.Peek();
                int currGrey = greyTile.Peek();
                if (currWhite == currGrey)
                {
                    if (currWhite + currGrey == 40)
                    {
                        map["Sink"]++;
                        whiteTile.Pop();
                        greyTile.Dequeue();
                    }
                    else if (currWhite + currGrey == 50)
                    {
                        map["Oven"]++;
                        whiteTile.Pop();
                        greyTile.Dequeue();
                    }
                    else if (currWhite + currGrey == 60)
                    {
                        map["Countertop"]++;
                        whiteTile.Pop();
                        greyTile.Dequeue();
                    }
                    else if (currWhite + currGrey == 70)
                    {
                        map["Wall"]++;
                        whiteTile.Pop();
                        greyTile.Dequeue();
                    }

                    else
                    {
                        map["Floor"]++;
                        whiteTile.Pop();
                        greyTile.Dequeue();
                    }
                }
                else
                {
                    whiteTile.Push(whiteTile.Pop() / 2);
                    greyTile.Enqueue(greyTile.Dequeue());
                }
            }
            if (whiteTile.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ",whiteTile)}");
            }
            if (greyTile.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTile)}");
            }

            foreach (var item in map.OrderByDescending(n => n.Value))
            {
                if (item.Value>0)
                {
                Console.WriteLine($"{item.Key}: {item.Value}");

                }
            }

        }
    }
}
