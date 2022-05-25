using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
         var parking = new HashSet<string>();
            string input;
            while ((input=Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");
                string cmm = command[0];
                string name = command[1];
                if (cmm == "IN")
                {
                    parking.Add(name);
                }
                else
                {
                    parking.Remove(name);
                }
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
