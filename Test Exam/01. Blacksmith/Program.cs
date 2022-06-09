using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> total = new Dictionary<string, int>
            {
                {"Gladius",0 },
                {"Shamshir",0 },
                {"Katana",0 },
                {"Sabre",0 },
                {"Broadsword",0 },
            };

            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int curentSteel = steel.Peek();
                int curentCarbon = carbon.Peek();
                int percentWater = curentSteel + curentCarbon;
                switch (percentWater)
                {
                    case 70:
                        steel.Dequeue();
                        carbon.Pop();
                        total["Gladius"]++;
                        break;
                    case 80:

                        steel.Dequeue();
                        carbon.Pop();
                        total["Shamshir"]++;
                        break;
                    case 90:

                        steel.Dequeue();
                        carbon.Pop();
                        total["Katana"]++;
                        break;
                    case 110:

                        steel.Dequeue();
                        carbon.Pop();
                        total["Sabre"]++;
                        break;
                    case 150:
                        steel.Dequeue();
                        carbon.Pop();
                        total["Broadsword"]++;
                        break;

                    default:

                        carbon.Pop();
                        steel.Dequeue();
                        carbon.Push(curentCarbon + 5);
                        break;
                }

            }
            foreach (var item in total)
            {
                if (item.Value == 0)
                {
                    total.Remove(item.Key);
                }
            }
            if (total.Count>0)
            {
            Console.WriteLine($"You have forged {total.Values.Sum()} swords.");

            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            var steelLeft = steel.Count == 0 ? "none" : string.Join(", ", steel);
            var carbonLeft = carbon.Count == 0 ? "none" : string.Join(", ", carbon);

            Console.WriteLine($"Steel left: {steelLeft}");
            Console.WriteLine($"Carbon left: {carbonLeft}");

            foreach (var item in total.OrderBy(n =>n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
