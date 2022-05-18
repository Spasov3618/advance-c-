using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStations = int.Parse(Console.ReadLine());

            Queue<int> fuelLeft = new Queue<int>();

            for (int i = 0; i < numberOfStations; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                fuelLeft.Enqueue(input[0] - input[1]);
            }

            for (int i = 0; i < fuelLeft.Count; i++)
            {
                Queue<int> copyFuelLeft = new Queue<int>(fuelLeft);

                int currentFuel = 0;


                for (int j = 0; j < copyFuelLeft.Count; j++)
                {
                    currentFuel += copyFuelLeft.Dequeue();

                    if (currentFuel < 0)
                    {
                        break;
                    }

                }

                if (currentFuel >= 0)
                {
                    Console.WriteLine(i);
                    return;
                }

                fuelLeft.Enqueue(fuelLeft.Dequeue());
            }
        }
    }
}
