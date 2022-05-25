using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary <string,Dictionary<string,double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] parts = input.Split(",");
                string shop = parts[0];
                string product = parts[1];
                double price = double.Parse(parts[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }
                shops[shop][product] = price;
            }
            foreach (var item in shops.Keys)
            {
                Console.WriteLine(item + "->");
                foreach (var product in shops[item])
                {
                    Console.WriteLine($"Product:{product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
