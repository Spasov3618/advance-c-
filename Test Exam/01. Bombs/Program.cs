using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEfect = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bomb = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            SortedDictionary<string,int> bombs = new SortedDictionary<string, int>
            {
                {"Datura Bombs" ,0},
                {"Cherry Bombs",0 },
                {"Smoke Decoy Bombs",0}

            };
            while (bombEfect.Any() && bomb.Any())
            {
                int currEfect = bombEfect.Peek();
                int currBombs = bomb.Peek();
                if (currEfect+currBombs== 40)
                {
                    bombs["Datura Bombs"]++;
                    bombEfect.Dequeue();
                    bomb.Pop();

                }
                else if (currBombs+currEfect== 60)
                {
                    bombs["Cherry Bombs"]++;
                    bombEfect.Dequeue();
                    bomb.Pop();
                }
                else if (currEfect+currBombs == 120)
                {
                    bombs["Smoke Decoy Bombs"]++;
                    bombEfect.Dequeue();
                    bomb.Pop();
                }
                else
                {
                    bomb.Push(bomb.Pop() - 5);
                }
                if (bombs.All(n => n.Value >= 3))
                {
                    break;
                }
            }

            if (bombs.All(n=>n.Value>=3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombEfect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",bombEfect)}");
            }
            if (bomb.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bomb)}");
            }
            foreach (var item in bombs)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
