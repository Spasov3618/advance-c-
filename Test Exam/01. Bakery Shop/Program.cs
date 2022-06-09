using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> total = new Dictionary<string, int>
            {
                {"Muffin",0 },
                {"Baguette",0 },
                {"Bagel",0 },
                {"Croissant",0 },
            };
            
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            while (water.Count>0 && flour.Count>0)
            {
                double curentWater = water.Peek();
                double curentFlour = flour.Peek();
                double percentWater = (((curentWater / (curentWater + curentFlour)) * 100));
                switch (percentWater)
                {
                    case  40:
                       
                        water.Dequeue();
                        flour.Pop();
                        total["Muffin"]++;
                        break;
                    case 30:
                       
                        water.Dequeue();
                        flour.Pop();
                        total["Baguette"]++;
                        break;
                    case 20:
                       
                        water.Dequeue();
                        flour.Pop();
                        total["Bagel"]++;
                        break;
                    case 50:
                       
                        water.Dequeue();
                        flour.Pop();
                        total["Croissant"]++;
                        break;

                    default:
                        flour.Pop();
                        water.Dequeue();
                        if (water.Count == 0)
                        {
                        double restFlour = curentFlour - curentWater;
                        flour.Push(restFlour);

                        }
                        else if(flour.Count == 0)
                        {
                            double restWater = curentWater - curentFlour;
                            water.Enqueue(restWater);
                        }

                        
                        total["Croissant"]++;
                        break;
                }

            }
            foreach (var item in total.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                if (item.Value>0)
                {
                Console.WriteLine($"{item.Key}: {item.Value}");

                }
            }
            if (water.Count==0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ",water)}");
            }
            if (flour.Count==0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ",flour)}");
            }
            
        }
    }
}
